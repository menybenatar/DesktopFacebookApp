namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlMainComponent = new System.Windows.Forms.TabControl();
            this.tabPageUserProfile = new System.Windows.Forms.TabPage();
            this.labelBierthday = new System.Windows.Forms.Label();
            this.labelHomeTown = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthdayTitle = new System.Windows.Forms.Label();
            this.labelEmailTitle = new System.Windows.Forms.Label();
            this.labelHomwTownTitle = new System.Windows.Forms.Label();
            this.labelGenderTitle = new System.Windows.Forms.Label();
            this.labelUserNameTitle = new System.Windows.Forms.Label();
            this.pictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxCoverImage = new System.Windows.Forms.PictureBox();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbumsTitle = new System.Windows.Forms.Label();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCommonInterests = new System.Windows.Forms.TabPage();
            this.labelCommonPages = new System.Windows.Forms.Label();
            this.labelLikedPagesTitle = new System.Windows.Forms.Label();
            this.labelCommonFriendTitle = new System.Windows.Forms.Label();
            this.labelCommonFriendName = new System.Windows.Forms.Label();
            this.pictureBoxCommonFriendPicture = new System.Windows.Forms.PictureBox();
            this.buttonFindCommonInterests = new System.Windows.Forms.Button();
            this.listBoxCommonInterests = new System.Windows.Forms.ListBox();
            this.listBoxMyPages = new System.Windows.Forms.ListBox();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialogAlbumDownload = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogAlbumDownload = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialogAlbum = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlMainComponent.SuspendLayout();
            this.tabPageUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.tabPageCommonInterests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(916, 428);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(915, 430);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlMainComponent
            // 
            this.tabControlMainComponent.Controls.Add(this.tabPageUserProfile);
            this.tabControlMainComponent.Controls.Add(this.tabPageAlbums);
            this.tabControlMainComponent.Controls.Add(this.tabPagePosts);
            this.tabControlMainComponent.Controls.Add(this.tabPageCommonInterests);
            this.tabControlMainComponent.Location = new System.Drawing.Point(1, 166);
            this.tabControlMainComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMainComponent.Name = "tabControlMainComponent";
            this.tabControlMainComponent.SelectedIndex = 0;
            this.tabControlMainComponent.Size = new System.Drawing.Size(1169, 496);
            this.tabControlMainComponent.TabIndex = 54;
            // 
            // tabPageUserProfile
            // 
            this.tabPageUserProfile.Controls.Add(this.labelBierthday);
            this.tabPageUserProfile.Controls.Add(this.labelHomeTown);
            this.tabPageUserProfile.Controls.Add(this.labelEmail);
            this.tabPageUserProfile.Controls.Add(this.labelGender);
            this.tabPageUserProfile.Controls.Add(this.labelBirthdayTitle);
            this.tabPageUserProfile.Controls.Add(this.labelEmailTitle);
            this.tabPageUserProfile.Controls.Add(this.labelHomwTownTitle);
            this.tabPageUserProfile.Controls.Add(this.labelGenderTitle);
            this.tabPageUserProfile.Controls.Add(this.labelUserNameTitle);
            this.tabPageUserProfile.Controls.Add(this.pictureBoxProfileImage);
            this.tabPageUserProfile.Controls.Add(this.labelUserName);
            this.tabPageUserProfile.Controls.Add(this.pictureBoxCoverImage);
            this.tabPageUserProfile.Controls.Add(this.buttonLogin);
            this.tabPageUserProfile.Controls.Add(this.buttonLogout);
            this.tabPageUserProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUserProfile.Name = "tabPageUserProfile";
            this.tabPageUserProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUserProfile.Size = new System.Drawing.Size(1161, 467);
            this.tabPageUserProfile.TabIndex = 0;
            this.tabPageUserProfile.Text = "My Profile";
            this.tabPageUserProfile.UseVisualStyleBackColor = true;
            // 
            // labelBierthday
            // 
            this.labelBierthday.AutoSize = true;
            this.labelBierthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBierthday.Location = new System.Drawing.Point(832, 276);
            this.labelBierthday.Name = "labelBierthday";
            this.labelBierthday.Size = new System.Drawing.Size(0, 20);
            this.labelBierthday.TabIndex = 64;
            // 
            // labelHomeTown
            // 
            this.labelHomeTown.AutoSize = true;
            this.labelHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeTown.Location = new System.Drawing.Point(832, 231);
            this.labelHomeTown.Name = "labelHomeTown";
            this.labelHomeTown.Size = new System.Drawing.Size(0, 20);
            this.labelHomeTown.TabIndex = 63;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(832, 183);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 20);
            this.labelEmail.TabIndex = 62;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(832, 139);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 20);
            this.labelGender.TabIndex = 61;
            // 
            // labelBirthdayTitle
            // 
            this.labelBirthdayTitle.AutoSize = true;
            this.labelBirthdayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayTitle.Location = new System.Drawing.Point(665, 276);
            this.labelBirthdayTitle.Name = "labelBirthdayTitle";
            this.labelBirthdayTitle.Size = new System.Drawing.Size(80, 20);
            this.labelBirthdayTitle.TabIndex = 60;
            this.labelBirthdayTitle.Text = "Birthday:";
            // 
            // labelEmailTitle
            // 
            this.labelEmailTitle.AutoSize = true;
            this.labelEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailTitle.Location = new System.Drawing.Point(665, 183);
            this.labelEmailTitle.Name = "labelEmailTitle";
            this.labelEmailTitle.Size = new System.Drawing.Size(129, 20);
            this.labelEmailTitle.TabIndex = 59;
            this.labelEmailTitle.Text = "Email Address:";
            // 
            // labelHomwTownTitle
            // 
            this.labelHomwTownTitle.AutoSize = true;
            this.labelHomwTownTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomwTownTitle.Location = new System.Drawing.Point(665, 231);
            this.labelHomwTownTitle.Name = "labelHomwTownTitle";
            this.labelHomwTownTitle.Size = new System.Drawing.Size(108, 20);
            this.labelHomwTownTitle.TabIndex = 58;
            this.labelHomwTownTitle.Text = "Home Town:";
            // 
            // labelGenderTitle
            // 
            this.labelGenderTitle.AutoSize = true;
            this.labelGenderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderTitle.Location = new System.Drawing.Point(665, 139);
            this.labelGenderTitle.Name = "labelGenderTitle";
            this.labelGenderTitle.Size = new System.Drawing.Size(74, 20);
            this.labelGenderTitle.TabIndex = 57;
            this.labelGenderTitle.Text = "Gender:";
            // 
            // labelUserNameTitle
            // 
            this.labelUserNameTitle.AutoSize = true;
            this.labelUserNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameTitle.Location = new System.Drawing.Point(665, 95);
            this.labelUserNameTitle.Name = "labelUserNameTitle";
            this.labelUserNameTitle.Size = new System.Drawing.Size(103, 20);
            this.labelUserNameTitle.TabIndex = 56;
            this.labelUserNameTitle.Text = "User Name:";
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfileImage.ErrorImage = null;
            this.pictureBoxProfileImage.Image = global::BasicFacebookFeatures.Properties.Resources.EmptyUserLogo;
            this.pictureBoxProfileImage.InitialImage = null;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(19, 17);
            this.pictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(213, 200);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 53;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(832, 95);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 20);
            this.labelUserName.TabIndex = 55;
            // 
            // pictureBoxCoverImage
            // 
            this.pictureBoxCoverImage.Location = new System.Drawing.Point(103, 78);
            this.pictureBoxCoverImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            this.pictureBoxCoverImage.Size = new System.Drawing.Size(544, 335);
            this.pictureBoxCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverImage.TabIndex = 54;
            this.pictureBoxCoverImage.TabStop = false;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.buttonDownloadAlbum);
            this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
            this.tabPageAlbums.Controls.Add(this.labelAlbumsTitle);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAlbums.Size = new System.Drawing.Size(1161, 467);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(495, 347);
            this.buttonDownloadAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(317, 63);
            this.buttonDownloadAlbum.TabIndex = 3;
            this.buttonDownloadAlbum.Text = "Please Select Albums To Download!";
            this.buttonDownloadAlbum.UseMnemonic = false;
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(72, 70);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAlbums.Size = new System.Drawing.Size(365, 340);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbumsTitle
            // 
            this.labelAlbumsTitle.AutoSize = true;
            this.labelAlbumsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsTitle.Location = new System.Drawing.Point(491, 12);
            this.labelAlbumsTitle.Name = "labelAlbumsTitle";
            this.labelAlbumsTitle.Size = new System.Drawing.Size(146, 29);
            this.labelAlbumsTitle.TabIndex = 0;
            this.labelAlbumsTitle.Text = "My Albums:";
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.dataGridViewPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 25);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePosts.Size = new System.Drawing.Size(1161, 467);
            this.tabPagePosts.TabIndex = 2;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPost,
            this.ColumnLikes,
            this.ColumnUploadDate});
            this.dataGridViewPosts.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPosts.Location = new System.Drawing.Point(189, 98);
            this.dataGridViewPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.RowTemplate.Height = 24;
            this.dataGridViewPosts.Size = new System.Drawing.Size(781, 277);
            this.dataGridViewPosts.TabIndex = 0;
            // 
            // ColumnPost
            // 
            this.ColumnPost.HeaderText = "Posts";
            this.ColumnPost.Name = "ColumnPost";
            this.ColumnPost.Width = 230;
            // 
            // ColumnLikes
            // 
            this.ColumnLikes.HeaderText = "Likes";
            this.ColumnLikes.Name = "ColumnLikes";
            this.ColumnLikes.Width = 130;
            // 
            // ColumnUploadDate
            // 
            this.ColumnUploadDate.HeaderText = "Upload Date";
            this.ColumnUploadDate.Name = "ColumnUploadDate";
            this.ColumnUploadDate.Width = 180;
            // 
            // tabPageCommonInterests
            // 
            this.tabPageCommonInterests.Controls.Add(this.labelCommonPages);
            this.tabPageCommonInterests.Controls.Add(this.labelLikedPagesTitle);
            this.tabPageCommonInterests.Controls.Add(this.labelCommonFriendTitle);
            this.tabPageCommonInterests.Controls.Add(this.labelCommonFriendName);
            this.tabPageCommonInterests.Controls.Add(this.pictureBoxCommonFriendPicture);
            this.tabPageCommonInterests.Controls.Add(this.buttonFindCommonInterests);
            this.tabPageCommonInterests.Controls.Add(this.listBoxCommonInterests);
            this.tabPageCommonInterests.Controls.Add(this.listBoxMyPages);
            this.tabPageCommonInterests.Location = new System.Drawing.Point(4, 25);
            this.tabPageCommonInterests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCommonInterests.Name = "tabPageCommonInterests";
            this.tabPageCommonInterests.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCommonInterests.Size = new System.Drawing.Size(1161, 467);
            this.tabPageCommonInterests.TabIndex = 3;
            this.tabPageCommonInterests.Text = "Common Interests";
            this.tabPageCommonInterests.UseVisualStyleBackColor = true;
            // 
            // labelCommonPages
            // 
            this.labelCommonPages.AutoSize = true;
            this.labelCommonPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommonPages.Location = new System.Drawing.Point(767, 4);
            this.labelCommonPages.Name = "labelCommonPages";
            this.labelCommonPages.Size = new System.Drawing.Size(196, 24);
            this.labelCommonPages.TabIndex = 9;
            this.labelCommonPages.Text = "Your Common Pages:";
            this.labelCommonPages.Visible = false;
            // 
            // labelLikedPagesTitle
            // 
            this.labelLikedPagesTitle.AutoSize = true;
            this.labelLikedPagesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPagesTitle.Location = new System.Drawing.Point(52, 4);
            this.labelLikedPagesTitle.Name = "labelLikedPagesTitle";
            this.labelLikedPagesTitle.Size = new System.Drawing.Size(163, 24);
            this.labelLikedPagesTitle.TabIndex = 6;
            this.labelLikedPagesTitle.Text = "Your Liked Pages:";
            // 
            // labelCommonFriendTitle
            // 
            this.labelCommonFriendTitle.AutoSize = true;
            this.labelCommonFriendTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommonFriendTitle.Location = new System.Drawing.Point(439, 17);
            this.labelCommonFriendTitle.Name = "labelCommonFriendTitle";
            this.labelCommonFriendTitle.Size = new System.Drawing.Size(225, 24);
            this.labelCommonFriendTitle.TabIndex = 5;
            this.labelCommonFriendTitle.Text = "This is Your Best Friend!!!";
            this.labelCommonFriendTitle.Visible = false;
            // 
            // labelCommonFriendName
            // 
            this.labelCommonFriendName.AutoSize = true;
            this.labelCommonFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommonFriendName.Location = new System.Drawing.Point(467, 69);
            this.labelCommonFriendName.Name = "labelCommonFriendName";
            this.labelCommonFriendName.Size = new System.Drawing.Size(57, 20);
            this.labelCommonFriendName.TabIndex = 4;
            this.labelCommonFriendName.Text = "";
            this.labelCommonFriendName.Visible = false;
            // 
            // pictureBoxCommonFriendPicture
            // 
            this.pictureBoxCommonFriendPicture.Location = new System.Drawing.Point(452, 100);
            this.pictureBoxCommonFriendPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCommonFriendPicture.Name = "pictureBoxCommonFriendPicture";
            this.pictureBoxCommonFriendPicture.Size = new System.Drawing.Size(200, 199);
            this.pictureBoxCommonFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommonFriendPicture.TabIndex = 3;
            this.pictureBoxCommonFriendPicture.TabStop = false;
            // 
            // buttonFindCommonInterests
            // 
            this.buttonFindCommonInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindCommonInterests.Location = new System.Drawing.Point(400, 330);
            this.buttonFindCommonInterests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindCommonInterests.Name = "buttonFindCommonInterests";
            this.buttonFindCommonInterests.Size = new System.Drawing.Size(313, 62);
            this.buttonFindCommonInterests.TabIndex = 2;
            this.buttonFindCommonInterests.Text = "Find Your Friend With The Most Common Interests!";
            this.buttonFindCommonInterests.UseVisualStyleBackColor = true;
            this.buttonFindCommonInterests.Click += new System.EventHandler(this.buttonFindCommonInterests_Click);
            // 
            // listBoxCommonInterests
            // 
            this.listBoxCommonInterests.FormattingEnabled = true;
            this.listBoxCommonInterests.ItemHeight = 16;
            this.listBoxCommonInterests.Location = new System.Drawing.Point(771, 33);
            this.listBoxCommonInterests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCommonInterests.Name = "listBoxCommonInterests";
            this.listBoxCommonInterests.Size = new System.Drawing.Size(279, 388);
            this.listBoxCommonInterests.TabIndex = 1;
            // 
            // listBoxMyPages
            // 
            this.listBoxMyPages.FormattingEnabled = true;
            this.listBoxMyPages.ItemHeight = 16;
            this.listBoxMyPages.Location = new System.Drawing.Point(53, 36);
            this.listBoxMyPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMyPages.Name = "listBoxMyPages";
            this.listBoxMyPages.Size = new System.Drawing.Size(291, 388);
            this.listBoxMyPages.TabIndex = 0;
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.ErrorImage")));
            this.pictureBoxMainLogo.Image = global::BasicFacebookFeatures.Properties.Resources.thefacebookLogo;
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxMainLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(1173, 166);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainLogo.TabIndex = 53;
            this.pictureBoxMainLogo.TabStop = false;
            this.pictureBoxMainLogo.Click += new System.EventHandler(this.pictureBoxMainLogo_Click);
            // 
            // openFileDialogAlbumDownload
            // 
            this.openFileDialogAlbumDownload.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tabControlMainComponent);
            this.Controls.Add(this.pictureBoxMainLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheFacebook";
            this.tabControlMainComponent.ResumeLayout(false);
            this.tabPageUserProfile.ResumeLayout(false);
            this.tabPageUserProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            this.tabPagePosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.tabPageCommonInterests.ResumeLayout(false);
            this.tabPageCommonInterests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.TabControl tabControlMainComponent;
        private System.Windows.Forms.TabPage tabPageUserProfile;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TabPage tabPageCommonInterests;
        private System.Windows.Forms.PictureBox pictureBoxCoverImage;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelBierthday;
        private System.Windows.Forms.Label labelHomeTown;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthdayTitle;
        private System.Windows.Forms.Label labelEmailTitle;
        private System.Windows.Forms.Label labelHomwTownTitle;
        private System.Windows.Forms.Label labelGenderTitle;
        private System.Windows.Forms.Label labelUserNameTitle;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbumsTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialogAlbumDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAlbumDownload;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAlbum;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLikes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUploadDate;
        private System.Windows.Forms.ListBox listBoxMyPages;
        private System.Windows.Forms.Label labelCommonFriendTitle;
        private System.Windows.Forms.Label labelCommonFriendName;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriendPicture;
        private System.Windows.Forms.Button buttonFindCommonInterests;
        private System.Windows.Forms.ListBox listBoxCommonInterests;
        private System.Windows.Forms.Label labelCommonPages;
        private System.Windows.Forms.Label labelLikedPagesTitle;
    }
}

