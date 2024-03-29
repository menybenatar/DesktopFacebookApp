﻿namespace BasicFacebookFeatures
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelDescription;
            System.Windows.Forms.Label labelName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlMainComponent = new System.Windows.Forms.TabControl();
            this.tabPageUserProfile = new System.Windows.Forms.TabPage();
            this.labelBierthday = new System.Windows.Forms.Label();
            this.labelHomeTown = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthdayTitle = new BasicFacebookFeatures.LabelObserver();
            this.labelEmailTitle = new BasicFacebookFeatures.LabelObserver();
            this.labelHomwTownTitle = new BasicFacebookFeatures.LabelObserver();
            this.labelGenderTitle = new BasicFacebookFeatures.LabelObserver();
            this.labelUserNameTitle = new BasicFacebookFeatures.LabelObserver();
            this.pictureBoxProfileImage = new BasicFacebookFeatures.ResizePictureBoxProxy();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxCoverImage = new BasicFacebookFeatures.ResizePictureBoxProxy();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.buttonDownloadAlbum = new BasicFacebookFeatures.ButtonObserver();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbumsTitle = new System.Windows.Forms.Label();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCommonInterests = new System.Windows.Forms.TabPage();
            this.buttonDesc = new BasicFacebookFeatures.ButtonObserver();
            this.buttonAsc = new BasicFacebookFeatures.ButtonObserver();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCommonPages = new System.Windows.Forms.Label();
            this.labelLikedPagesTitle = new System.Windows.Forms.Label();
            this.labelCommonFriendTitle = new System.Windows.Forms.Label();
            this.labelCommonFriendName = new System.Windows.Forms.Label();
            this.pictureBoxCommonFriendPicture = new System.Windows.Forms.PictureBox();
            this.buttonFindCommonInterests = new BasicFacebookFeatures.ButtonObserver();
            this.listBoxCommonInterests = new System.Windows.Forms.ListBox();
            this.listBoxMyPages = new System.Windows.Forms.ListBox();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialogAlbumDownload = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogAlbumDownload = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialogAlbum = new System.Windows.Forms.FolderBrowserDialog();
            labelDescription = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            this.tabControlMainComponent.SuspendLayout();
            this.tabPageUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.tabPageCommonInterests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(314, 326);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(63, 13);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "Description:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(314, 352);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(38, 13);
            labelName.TabIndex = 11;
            labelName.Text = "Name:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(687, 348);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(686, 349);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
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
            this.tabControlMainComponent.Location = new System.Drawing.Point(1, 135);
            this.tabControlMainComponent.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMainComponent.Name = "tabControlMainComponent";
            this.tabControlMainComponent.SelectedIndex = 0;
            this.tabControlMainComponent.Size = new System.Drawing.Size(877, 403);
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
            this.tabPageUserProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageUserProfile.Name = "tabPageUserProfile";
            this.tabPageUserProfile.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageUserProfile.Size = new System.Drawing.Size(869, 377);
            this.tabPageUserProfile.TabIndex = 0;
            this.tabPageUserProfile.Text = "My Profile";
            this.tabPageUserProfile.UseVisualStyleBackColor = true;
            // 
            // labelBierthday
            // 
            this.labelBierthday.AutoSize = true;
            this.labelBierthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBierthday.Location = new System.Drawing.Point(624, 224);
            this.labelBierthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBierthday.Name = "labelBierthday";
            this.labelBierthday.Size = new System.Drawing.Size(0, 20);
            this.labelBierthday.TabIndex = 64;
            // 
            // labelHomeTown
            // 
            this.labelHomeTown.AutoSize = true;
            this.labelHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeTown.Location = new System.Drawing.Point(624, 188);
            this.labelHomeTown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHomeTown.Name = "labelHomeTown";
            this.labelHomeTown.Size = new System.Drawing.Size(0, 20);
            this.labelHomeTown.TabIndex = 63;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(624, 149);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 20);
            this.labelEmail.TabIndex = 62;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(624, 113);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 20);
            this.labelGender.TabIndex = 61;
            // 
            // labelBirthdayTitle
            // 
            this.labelBirthdayTitle.AutoSize = true;
            this.labelBirthdayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayTitle.Location = new System.Drawing.Point(499, 224);
            this.labelBirthdayTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthdayTitle.Name = "labelBirthdayTitle";
            this.labelBirthdayTitle.Size = new System.Drawing.Size(80, 20);
            this.labelBirthdayTitle.TabIndex = 60;
            this.labelBirthdayTitle.Text = "Birthday:";
            this.labelBirthdayTitle.Visible = false;
            // 
            // labelEmailTitle
            // 
            this.labelEmailTitle.AutoSize = true;
            this.labelEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailTitle.Location = new System.Drawing.Point(499, 149);
            this.labelEmailTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailTitle.Name = "labelEmailTitle";
            this.labelEmailTitle.Size = new System.Drawing.Size(129, 20);
            this.labelEmailTitle.TabIndex = 59;
            this.labelEmailTitle.Text = "Email Address:";
            this.labelEmailTitle.Visible = false;
            // 
            // labelHomwTownTitle
            // 
            this.labelHomwTownTitle.AutoSize = true;
            this.labelHomwTownTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomwTownTitle.Location = new System.Drawing.Point(499, 188);
            this.labelHomwTownTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHomwTownTitle.Name = "labelHomwTownTitle";
            this.labelHomwTownTitle.Size = new System.Drawing.Size(108, 20);
            this.labelHomwTownTitle.TabIndex = 58;
            this.labelHomwTownTitle.Text = "Home Town:";
            this.labelHomwTownTitle.Visible = false;
            // 
            // labelGenderTitle
            // 
            this.labelGenderTitle.AutoSize = true;
            this.labelGenderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderTitle.Location = new System.Drawing.Point(499, 113);
            this.labelGenderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenderTitle.Name = "labelGenderTitle";
            this.labelGenderTitle.Size = new System.Drawing.Size(74, 20);
            this.labelGenderTitle.TabIndex = 57;
            this.labelGenderTitle.Text = "Gender:";
            this.labelGenderTitle.Visible = false;
            // 
            // labelUserNameTitle
            // 
            this.labelUserNameTitle.AutoSize = true;
            this.labelUserNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameTitle.Location = new System.Drawing.Point(499, 77);
            this.labelUserNameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserNameTitle.Name = "labelUserNameTitle";
            this.labelUserNameTitle.Size = new System.Drawing.Size(103, 20);
            this.labelUserNameTitle.TabIndex = 56;
            this.labelUserNameTitle.Text = "User Name:";
            this.labelUserNameTitle.Visible = false;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfileImage.ErrorImage = null;
            this.pictureBoxProfileImage.Image = global::BasicFacebookFeatures.Properties.Resources.EmptyUserLogo;
            this.pictureBoxProfileImage.InitialImage = null;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(161, 163);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 53;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(624, 77);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 20);
            this.labelUserName.TabIndex = 55;
            // 
            // pictureBoxCoverImage
            // 
            this.pictureBoxCoverImage.Location = new System.Drawing.Point(77, 63);
            this.pictureBoxCoverImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            this.pictureBoxCoverImage.Size = new System.Drawing.Size(408, 272);
            this.pictureBoxCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverImage.TabIndex = 54;
            this.pictureBoxCoverImage.TabStop = false;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.buttonDownloadAlbum);
            this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
            this.tabPageAlbums.Controls.Add(this.labelAlbumsTitle);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAlbums.Size = new System.Drawing.Size(869, 377);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.Enabled = false;
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(371, 282);
            this.buttonDownloadAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(238, 51);
            this.buttonDownloadAlbum.TabIndex = 3;
            this.buttonDownloadAlbum.Text = "Please Select Albums To Download!";
            this.buttonDownloadAlbum.UseMnemonic = false;
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(54, 57);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAlbums.Size = new System.Drawing.Size(275, 277);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbumsTitle
            // 
            this.labelAlbumsTitle.AutoSize = true;
            this.labelAlbumsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsTitle.Location = new System.Drawing.Point(368, 10);
            this.labelAlbumsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbumsTitle.Name = "labelAlbumsTitle";
            this.labelAlbumsTitle.Size = new System.Drawing.Size(146, 29);
            this.labelAlbumsTitle.TabIndex = 0;
            this.labelAlbumsTitle.Text = "My Albums:";
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.dataGridViewPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePosts.Size = new System.Drawing.Size(869, 377);
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
            this.dataGridViewPosts.Location = new System.Drawing.Point(142, 80);
            this.dataGridViewPosts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.RowTemplate.Height = 24;
            this.dataGridViewPosts.Size = new System.Drawing.Size(586, 225);
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
            this.tabPageCommonInterests.Controls.Add(this.buttonDesc);
            this.tabPageCommonInterests.Controls.Add(this.buttonAsc);
            this.tabPageCommonInterests.Controls.Add(labelDescription);
            this.tabPageCommonInterests.Controls.Add(this.textBoxDescription);
            this.tabPageCommonInterests.Controls.Add(labelName);
            this.tabPageCommonInterests.Controls.Add(this.textBoxName);
            this.tabPageCommonInterests.Controls.Add(this.labelCommonPages);
            this.tabPageCommonInterests.Controls.Add(this.labelLikedPagesTitle);
            this.tabPageCommonInterests.Controls.Add(this.labelCommonFriendTitle);
            this.tabPageCommonInterests.Controls.Add(this.labelCommonFriendName);
            this.tabPageCommonInterests.Controls.Add(this.pictureBoxCommonFriendPicture);
            this.tabPageCommonInterests.Controls.Add(this.buttonFindCommonInterests);
            this.tabPageCommonInterests.Controls.Add(this.listBoxCommonInterests);
            this.tabPageCommonInterests.Controls.Add(this.listBoxMyPages);
            this.tabPageCommonInterests.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommonInterests.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCommonInterests.Name = "tabPageCommonInterests";
            this.tabPageCommonInterests.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCommonInterests.Size = new System.Drawing.Size(869, 377);
            this.tabPageCommonInterests.TabIndex = 3;
            this.tabPageCommonInterests.Text = "Common Interests";
            this.tabPageCommonInterests.UseVisualStyleBackColor = true;
            // 
            // buttonDesc
            // 
            this.buttonDesc.Enabled = false;
            this.buttonDesc.Location = new System.Drawing.Point(170, 272);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(75, 45);
            this.buttonDesc.TabIndex = 14;
            this.buttonDesc.Text = "Sort Descending ";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonAsc
            // 
            this.buttonAsc.Enabled = false;
            this.buttonAsc.Location = new System.Drawing.Point(53, 272);
            this.buttonAsc.Name = "buttonAsc";
            this.buttonAsc.Size = new System.Drawing.Size(75, 45);
            this.buttonAsc.TabIndex = 13;
            this.buttonAsc.Text = "Sort Ascending ";
            this.buttonAsc.UseVisualStyleBackColor = true;
            this.buttonAsc.Click += new System.EventHandler(this.buttonAsc_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.textBoxDescription.Location = new System.Drawing.Point(383, 323);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(383, 349);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // labelCommonPages
            // 
            this.labelCommonPages.AutoSize = true;
            this.labelCommonPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommonPages.Location = new System.Drawing.Point(575, 3);
            this.labelCommonPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelLikedPagesTitle.Location = new System.Drawing.Point(39, 3);
            this.labelLikedPagesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikedPagesTitle.Name = "labelLikedPagesTitle";
            this.labelLikedPagesTitle.Size = new System.Drawing.Size(163, 24);
            this.labelLikedPagesTitle.TabIndex = 6;
            this.labelLikedPagesTitle.Text = "Your Liked Pages:";
            // 
            // labelCommonFriendTitle
            // 
            this.labelCommonFriendTitle.AutoSize = true;
            this.labelCommonFriendTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommonFriendTitle.Location = new System.Drawing.Point(296, 14);
            this.labelCommonFriendTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelCommonFriendName.Location = new System.Drawing.Point(350, 56);
            this.labelCommonFriendName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommonFriendName.Name = "labelCommonFriendName";
            this.labelCommonFriendName.Size = new System.Drawing.Size(0, 20);
            this.labelCommonFriendName.TabIndex = 4;
            this.labelCommonFriendName.Visible = false;
            // 
            // pictureBoxCommonFriendPicture
            // 
            this.pictureBoxCommonFriendPicture.Location = new System.Drawing.Point(333, 88);
            this.pictureBoxCommonFriendPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCommonFriendPicture.Name = "pictureBoxCommonFriendPicture";
            this.pictureBoxCommonFriendPicture.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxCommonFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommonFriendPicture.TabIndex = 3;
            this.pictureBoxCommonFriendPicture.TabStop = false;
            // 
            // buttonFindCommonInterests
            // 
            this.buttonFindCommonInterests.Enabled = false;
            this.buttonFindCommonInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindCommonInterests.Location = new System.Drawing.Point(286, 254);
            this.buttonFindCommonInterests.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindCommonInterests.Name = "buttonFindCommonInterests";
            this.buttonFindCommonInterests.Size = new System.Drawing.Size(235, 50);
            this.buttonFindCommonInterests.TabIndex = 2;
            this.buttonFindCommonInterests.Text = "Find Your Friend With The Most Common Interests!";
            this.buttonFindCommonInterests.UseVisualStyleBackColor = true;
            this.buttonFindCommonInterests.Click += new System.EventHandler(this.buttonFindCommonInterests_Click);
            // 
            // listBoxCommonInterests
            // 
            this.listBoxCommonInterests.FormattingEnabled = true;
            this.listBoxCommonInterests.Location = new System.Drawing.Point(578, 27);
            this.listBoxCommonInterests.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCommonInterests.Name = "listBoxCommonInterests";
            this.listBoxCommonInterests.Size = new System.Drawing.Size(210, 316);
            this.listBoxCommonInterests.TabIndex = 1;
            // 
            // listBoxMyPages
            // 
            this.listBoxMyPages.DataSource = this.pageBindingSource;
            this.listBoxMyPages.DisplayMember = "Name";
            this.listBoxMyPages.FormattingEnabled = true;
            this.listBoxMyPages.Location = new System.Drawing.Point(40, 29);
            this.listBoxMyPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMyPages.Name = "listBoxMyPages";
            this.listBoxMyPages.Size = new System.Drawing.Size(219, 238);
            this.listBoxMyPages.TabIndex = 0;
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.ErrorImage")));
            this.pictureBoxMainLogo.Image = global::BasicFacebookFeatures.Properties.Resources.thefacebookLogo;
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxMainLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(880, 135);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(888, 538);
            this.Controls.Add(this.tabControlMainComponent);
            this.Controls.Add(this.pictureBoxMainLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
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
        private ResizePictureBoxProxy pictureBoxCoverImage;
        private ResizePictureBoxProxy pictureBoxProfileImage;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelBierthday;
        private System.Windows.Forms.Label labelHomeTown;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private LabelObserver labelBirthdayTitle;
        private LabelObserver labelEmailTitle;
        private LabelObserver labelHomwTownTitle;
        private LabelObserver labelGenderTitle;
        private LabelObserver labelUserNameTitle;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbumsTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialogAlbumDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialogAlbumDownload;
        private ButtonObserver buttonDownloadAlbum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAlbum;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLikes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUploadDate;
        private System.Windows.Forms.ListBox listBoxMyPages;
        private System.Windows.Forms.Label labelCommonFriendTitle;
        private System.Windows.Forms.Label labelCommonFriendName;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriendPicture;
        private ButtonObserver buttonFindCommonInterests;
        private System.Windows.Forms.ListBox listBoxCommonInterests;
        private System.Windows.Forms.Label labelCommonPages;
        private System.Windows.Forms.Label labelLikedPagesTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TextBox textBoxName;
        private ButtonObserver buttonDesc;
        private ButtonObserver buttonAsc;
    }
}

