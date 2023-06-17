using System;
using System.Threading;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser { get; set; } = null;

        private AlbumDownloader m_AlbumDownloader { get; set; } = null;

        private CommonInterestsFinder m_commonInterestsFinder { get; set; } = null;

        private Sorter<Page> m_SorterPages { get; set;}

        private ControlNotifier m_ControlNotifier = new ControlNotifier();

        public FormMain()
        {
            InitializeComponent();
            attachControlObservers();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void attachControlObservers()
        {
            m_ControlNotifier.AttachObserver(buttonDownloadAlbum);
            m_ControlNotifier.AttachObserver(buttonAsc);
            m_ControlNotifier.AttachObserver(buttonDesc);
            m_ControlNotifier.AttachObserver(buttonFindCommonInterests);
            m_ControlNotifier.AttachObserver(labelBirthdayTitle);
            m_ControlNotifier.AttachObserver(labelEmailTitle);
            m_ControlNotifier.AttachObserver(labelUserNameTitle);
            m_ControlNotifier.AttachObserver(labelGenderTitle);
            m_ControlNotifier.AttachObserver(labelHomwTownTitle);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                InitObjects();
                new Thread(initData).Start();
                buttonLogin.Visible = false;
                buttonLogout.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}Login Failed, Please Try Again.");
            }
        }

        private void InitObjects()
        {
            const bool v_IsLoggedIn = true;
            m_LoggedInUser = LoggedInUserSingleton.Instance?.LoggedInUser;
            m_ControlNotifier.NotifyControlObservers(v_IsLoggedIn);
            m_AlbumDownloader = new AlbumDownloader();
            m_commonInterestsFinder = new CommonInterestsFinder();
            m_SorterPages = new Sorter<Page>(new AscendingPageSorter());
        }

        private void initData()
        {
            new Thread(displayUserInfo).Start();
            new Thread(loadAlbumsData).Start();
            new Thread(loadPostsData).Start();
            new Thread(loadPagesData).Start();
        }

        private void displayUserInfo()
        {
            pictureBoxProfileImage.LoadAsync(m_LoggedInUser.PictureLargeURL);
            string coverUrl = m_LoggedInUser.Albums.Where(x => x.Name == "Cover photos" || x.Name == "תמונות נושא").FirstOrDefault()?.Photos[0]?.PictureNormalURL;
            if (!string.IsNullOrEmpty(coverUrl))
            {
                pictureBoxCoverImage.LoadAsync(coverUrl);
            }

            labelHomeTown.Invoke(new Action(() => labelHomeTown.Text = m_LoggedInUser.Hometown?.Name != null ? m_LoggedInUser.Hometown.Name : "Holon"));
            labelUserName.Invoke(new Action(() => labelUserName.Text = m_LoggedInUser.Name));
            labelGender.Invoke(new Action(() => labelGender.Text = m_LoggedInUser.Gender.ToString()));
            labelEmail.Invoke(new Action(() => labelEmail.Text = m_LoggedInUser.Email));
            labelBierthday.Invoke(new Action(() => labelBierthday.Text = m_LoggedInUser.Birthday));
        }

        private void loadPagesData()
        {
            if (!listBoxMyPages.InvokeRequired)
            {
                pageBindingSource.DataSource = m_LoggedInUser.LikedPages;
            }
            else
            {
                listBoxMyPages.Invoke(new Action(() => pageBindingSource.DataSource = m_LoggedInUser.LikedPages));
            }
        }

        private void loadPostsData()
        {
            Random random = new Random();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                dataGridViewPosts.Invoke(new Action(() => dataGridViewPosts.Rows.Add(post.Message, random.Next(1, 200), post.CreatedTime)));
            }
        }

        private void loadAlbumsData()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
            }
        }

        private void loadCommonPages(List<Page> i_Pages)
        {
            listBoxCommonInterests.DisplayMember = "Name";
            foreach (Page page in i_Pages)
            {
                listBoxCommonInterests.Items.Add(page);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            const bool v_IsLoggedIn = false;
			FacebookService.LogoutWithUI();
            m_ControlNotifier.NotifyControlObservers(v_IsLoggedIn);
            buttonLogin.Visible = true;
			buttonLogout.Visible = false;
		}

        private void pictureBoxMainLogo_Click(object sender, EventArgs e)
        {
            tabControlMainComponent.SelectTab(0);
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.Items.Count > 0)
            {
                buttonDownloadAlbum.Text = $"Click Here To Download The Selected Albums!";
            }
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            List<int> selectedItemIndexes = listBoxAlbums.SelectedIndices.Cast<int>().ToList();
            bool isAllAlbumsSaved = true;
            string message;
            if (selectedItemIndexes.Count <= 0)
            {
                message = "Please Select The Wanted Album To Download.";
            }
            else
            {
                if (folderBrowserDialogAlbum.ShowDialog() == DialogResult.OK)
                {
                    if(m_AlbumDownloader.LoadAlbumsToSaveByIndexes(selectedItemIndexes))
                    {
                        for (IEnumerator it = (m_AlbumDownloader as IEnumerable).GetEnumerator(); it.MoveNext();)
                        {
                            if (!m_AlbumDownloader.DownloadAlbumImages(it.Current as Album, folderBrowserDialogAlbum.SelectedPath))
                            {
                                isAllAlbumsSaved = false;
                            }
                        }
                    }
                    else
                    {
                        isAllAlbumsSaved = false;
                    }

                    message = isAllAlbumsSaved ?
                        $"All Of Your Album Was Saved Successfuly to {folderBrowserDialogAlbum.SelectedPath}." :
                        $"Something Went Wrong, Some Of The Albums Were Not Saved. Please Try Again.";
                }
                else
                {
                    message = "Please Select A Folder To Save The Album.";
                }
            }

            MessageBox.Show(message);
        }

        private void buttonFindCommonInterests_Click(object sender, EventArgs e)
        {
            if(m_commonInterestsFinder != null)
            {
                KeyValuePair<User, List<Page>> theBestFriend = m_commonInterestsFinder.GetCommonInterestsFriends();
                labelCommonFriendName.Text = theBestFriend.Key.Name;
                labelCommonFriendName.Visible = true;
                labelCommonFriendTitle.Visible = true;
                labelCommonPages.Visible = true;
                listBoxCommonInterests.Items.Clear();
                pictureBoxCommonFriendPicture.LoadAsync(theBestFriend.Key.PictureLargeURL);
                loadCommonPages(theBestFriend.Value);
            }
            else
            {
                MessageBox.Show("Please Login First.");
            }
        }

        private void buttonAsc_Click(object sender,  EventArgs e)
        {
            if(m_LoggedInUser!=null)
            {
                List<Page> items = m_LoggedInUser.LikedPages.Cast<Page>().ToList();
                m_SorterPages.Comparer = new AscendingPageSorter();
                m_SorterPages.Sort(items);
                pageBindingSource.DataSource = items;
            }
            else
            {
                MessageBox.Show("Please Login First.");
            }
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                List<Page> items = m_LoggedInUser.LikedPages.Cast<Page>().ToList();
                m_SorterPages.Comparer = new DescendingPageSorter();
                m_SorterPages.Sort(items);
                pageBindingSource.DataSource = items;
            }
            else
            {
                MessageBox.Show("Please Login First.");
            }
        }
    }
}
