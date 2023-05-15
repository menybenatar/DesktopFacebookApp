using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser { get; set; } = null;
        private AlbumDownloader m_AlbumDownloader { get; set; } = null;
        private CommonInterestsFinder m_commonInterestsFinder { get; set; } = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
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
                MessageBox.Show($"Login Failed, Please Try Again.");
            }
        }

        private void InitObjects()
        {
            m_LoggedInUser = LoggedInUserSingleton.Instance?.LoggedInUser;
            m_AlbumDownloader = new AlbumDownloader();
            m_commonInterestsFinder = new CommonInterestsFinder();
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
            listBoxMyPages.Invoke(new Action(() => { listBoxMyPages.DisplayMember = "Name"; }));

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxMyPages.Invoke(new Action(() => listBoxMyPages.Items.Add(page)));
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
			FacebookService.LogoutWithUI();
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
            bool isAlbumsSaved;
            string message;
            if (selectedItemIndexes.Count <= 0)
            {
                message = "Please Select The Wanted Album To Download.";
            }
            else
            {
                if (folderBrowserDialogAlbum.ShowDialog() == DialogResult.OK)
                {
                    isAlbumsSaved = m_AlbumDownloader.DownloadAlbumsImages(selectedItemIndexes, folderBrowserDialogAlbum.SelectedPath);
                    message = isAlbumsSaved ?
                        $"Your Album Was Saved Successfuly to {folderBrowserDialogAlbum.SelectedPath}." :
                        $"Something Went Wrong, Please Try Again.";
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
                MessageBox.Show("error");
            }

        }

    }
}
