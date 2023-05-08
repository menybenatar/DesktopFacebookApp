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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private AlbumDownloader m_AlbumDownloader;
        private CommonInterestsFinder m_commonInterestsFinder;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //FacebookWrapper.LoginResult loginResult = FacebookService.Login(
            //      "908976190225309",
            //      "email",
            //      "user_hometown",
            //      "user_birthday",
            //      "user_gender",
            //      "user_photos",
            //      "user_friends",
            //      "user_likes",
            //      "user_posts",
            //      "public_profile",
            //      "groups_access_member_info");
            FacebookWrapper.LoginResult loginResult = FacebookService.Connect("EAAM6tYLte50BAPDvBZAvFAn2Lv94GAITqPgVVJn6NWZCe3K5zDdpqIogBIR2IPnJ0ZB4VBYxU1fWCk6ZBQkiXsTmX31C3ceeEOF8qS4y2nlT9vZAztA3qDYXdZBama3GVDKGyMu4sb0qsJA6VfdkEvp2HMxuMu3UcTAZCNwckKplnq45IN7h8dt");
            if (loginResult != null && !string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_LoggedInUser = loginResult.LoggedInUser;
                m_AlbumDownloader = new AlbumDownloader(m_LoggedInUser.Albums);
                m_commonInterestsFinder = new CommonInterestsFinder(m_LoggedInUser);
                initData();
                buttonLogin.Visible = false;
                buttonLogout.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Failed, Please Try Again.");
            }
        }

        private void initData()
        {
            displayUserInfo();
            loadAlbumsData();
            loadPostsData();
            loadPagesData();
        }

        private void loadPagesData()
        {
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxMyPages.Items.Add(page.Name);
            }
        }

        private void loadPostsData()
        {
            Random random = new Random();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                dataGridViewPosts.Rows.Add(post.Name, random.Next(1, 200), post.CreatedTime);
            }
        }

        private void loadAlbumsData()
        {
            foreach (Album page in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(page);
            }
        }

        private void displayUserInfo()
        {
            pictureBoxProfileImage.LoadAsync(m_LoggedInUser.PictureLargeURL);
            string coverUrl = m_LoggedInUser.Albums.Where(x => x.Name == "Cover photos" || x.Name == "תמונות נושא").FirstOrDefault()?.Photos[0]?.PictureNormalURL;
            if (!string.IsNullOrEmpty(coverUrl))
            {
                pictureBoxCoverImage.LoadAsync(coverUrl);
            }

            labelHomeTown.Text = m_LoggedInUser.Hometown?.Name != null ? m_LoggedInUser.Hometown.Name : "Holon";
            labelUserName.Text = m_LoggedInUser.Name;
            labelGender.Text = m_LoggedInUser.Gender.ToString();
            labelEmail.Text = m_LoggedInUser.Email;
            labelBierthday.Text = m_LoggedInUser.Birthday;
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

        private void loadCommonPages(List<Page> i_Pages)
        {
            foreach (Page page in i_Pages)
            {
                listBoxCommonInterests.Items.Add(page.Name);
            }
        }
    }
}
