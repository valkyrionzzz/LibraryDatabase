namespace AITMediaLibrary
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.selectedUserLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.deleteSelectedUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.genreGridView = new System.Windows.Forms.DataGridView();
            this.refreshbuttonGenre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.newGenreTextBox = new System.Windows.Forms.TextBox();
            this.addGenre = new System.Windows.Forms.Button();
            this.directorGridView = new System.Windows.Forms.DataGridView();
            this.Director = new System.Windows.Forms.Label();
            this.newDirectorTextBox = new System.Windows.Forms.TextBox();
            this.addDirector = new System.Windows.Forms.Button();
            this.refreshButtonDirector = new System.Windows.Forms.Button();
            this.LanguageGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.newLanguageTextBox = new System.Windows.Forms.TextBox();
            this.addLanguage = new System.Windows.Forms.Button();
            this.refreshButtonLanguage = new System.Windows.Forms.Button();
            this.MediaDataGridView = new System.Windows.Forms.DataGridView();
            this.Media = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.newTitleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.Language = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.addMedia = new System.Windows.Forms.Button();
            this.refreshButtonMedia = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.deleteButtonMedia = new System.Windows.Forms.Button();
            this.updateMedia = new System.Windows.Forms.Button();
            this.adminReservedGridView = new System.Windows.Forms.DataGridView();
            this.borrowGridView = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminReservedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Users";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(28, 43);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(240, 235);
            this.userGridView.TabIndex = 1;
            this.userGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellClick);
            // 
            // selectedUserLabel
            // 
            this.selectedUserLabel.AutoSize = true;
            this.selectedUserLabel.Location = new System.Drawing.Point(25, 298);
            this.selectedUserLabel.Name = "selectedUserLabel";
            this.selectedUserLabel.Size = new System.Drawing.Size(69, 13);
            this.selectedUserLabel.TabIndex = 2;
            this.selectedUserLabel.Text = "selectedUser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NewPassword";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(115, 318);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(153, 20);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(28, 346);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(240, 23);
            this.updatePasswordButton.TabIndex = 5;
            this.updatePasswordButton.Text = "UpdatePassword";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // deleteSelectedUser
            // 
            this.deleteSelectedUser.Location = new System.Drawing.Point(28, 375);
            this.deleteSelectedUser.Name = "deleteSelectedUser";
            this.deleteSelectedUser.Size = new System.Drawing.Size(240, 23);
            this.deleteSelectedUser.TabIndex = 6;
            this.deleteSelectedUser.Text = "Delete Selected User";
            this.deleteSelectedUser.UseVisualStyleBackColor = true;
            this.deleteSelectedUser.Click += new System.EventHandler(this.deleteSelectedUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(153, 452);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.userNameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(153, 485);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(153, 542);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(153, 514);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.userLevelComboBox.TabIndex = 14;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(274, 103);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(115, 568);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 16;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // genreGridView
            // 
            this.genreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreGridView.Location = new System.Drawing.Point(395, 43);
            this.genreGridView.Name = "genreGridView";
            this.genreGridView.Size = new System.Drawing.Size(249, 115);
            this.genreGridView.TabIndex = 17;
            // 
            // refreshbuttonGenre
            // 
            this.refreshbuttonGenre.Location = new System.Drawing.Point(650, 90);
            this.refreshbuttonGenre.Name = "refreshbuttonGenre";
            this.refreshbuttonGenre.Size = new System.Drawing.Size(75, 23);
            this.refreshbuttonGenre.TabIndex = 18;
            this.refreshbuttonGenre.Text = "Refresh";
            this.refreshbuttonGenre.UseVisualStyleBackColor = true;
            this.refreshbuttonGenre.Click += new System.EventHandler(this.refreshButtonGenre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Genre";
            // 
            // newGenreTextBox
            // 
            this.newGenreTextBox.Location = new System.Drawing.Point(430, 177);
            this.newGenreTextBox.Name = "newGenreTextBox";
            this.newGenreTextBox.Size = new System.Drawing.Size(143, 20);
            this.newGenreTextBox.TabIndex = 20;
            // 
            // addGenre
            // 
            this.addGenre.Location = new System.Drawing.Point(579, 175);
            this.addGenre.Name = "addGenre";
            this.addGenre.Size = new System.Drawing.Size(75, 23);
            this.addGenre.TabIndex = 21;
            this.addGenre.Text = "Add Genre";
            this.addGenre.UseVisualStyleBackColor = true;
            this.addGenre.Click += new System.EventHandler(this.addGenre_Click);
            // 
            // directorGridView
            // 
            this.directorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorGridView.Location = new System.Drawing.Point(395, 233);
            this.directorGridView.Name = "directorGridView";
            this.directorGridView.Size = new System.Drawing.Size(249, 115);
            this.directorGridView.TabIndex = 22;
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(392, 375);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(44, 13);
            this.Director.TabIndex = 23;
            this.Director.Text = "Director";
            // 
            // newDirectorTextBox
            // 
            this.newDirectorTextBox.Location = new System.Drawing.Point(442, 372);
            this.newDirectorTextBox.Name = "newDirectorTextBox";
            this.newDirectorTextBox.Size = new System.Drawing.Size(130, 20);
            this.newDirectorTextBox.TabIndex = 24;
            // 
            // addDirector
            // 
            this.addDirector.Location = new System.Drawing.Point(579, 372);
            this.addDirector.Name = "addDirector";
            this.addDirector.Size = new System.Drawing.Size(75, 23);
            this.addDirector.TabIndex = 25;
            this.addDirector.Text = "Add Director";
            this.addDirector.UseVisualStyleBackColor = true;
            this.addDirector.Click += new System.EventHandler(this.addDirector_Click);
            // 
            // refreshButtonDirector
            // 
            this.refreshButtonDirector.Location = new System.Drawing.Point(650, 277);
            this.refreshButtonDirector.Name = "refreshButtonDirector";
            this.refreshButtonDirector.Size = new System.Drawing.Size(75, 23);
            this.refreshButtonDirector.TabIndex = 26;
            this.refreshButtonDirector.Text = "Refresh";
            this.refreshButtonDirector.UseVisualStyleBackColor = true;
            this.refreshButtonDirector.Click += new System.EventHandler(this.refreshButtonDirector_Click);
            // 
            // LanguageGridView
            // 
            this.LanguageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LanguageGridView.Location = new System.Drawing.Point(395, 415);
            this.LanguageGridView.Name = "LanguageGridView";
            this.LanguageGridView.Size = new System.Drawing.Size(249, 115);
            this.LanguageGridView.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Language";
            // 
            // newLanguageTextBox
            // 
            this.newLanguageTextBox.Location = new System.Drawing.Point(453, 545);
            this.newLanguageTextBox.Name = "newLanguageTextBox";
            this.newLanguageTextBox.Size = new System.Drawing.Size(111, 20);
            this.newLanguageTextBox.TabIndex = 29;
            // 
            // addLanguage
            // 
            this.addLanguage.Location = new System.Drawing.Point(570, 543);
            this.addLanguage.Name = "addLanguage";
            this.addLanguage.Size = new System.Drawing.Size(92, 23);
            this.addLanguage.TabIndex = 30;
            this.addLanguage.Text = "Add Language";
            this.addLanguage.UseVisualStyleBackColor = true;
            this.addLanguage.Click += new System.EventHandler(this.addLanguage_Click);
            // 
            // refreshButtonLanguage
            // 
            this.refreshButtonLanguage.Location = new System.Drawing.Point(650, 478);
            this.refreshButtonLanguage.Name = "refreshButtonLanguage";
            this.refreshButtonLanguage.Size = new System.Drawing.Size(75, 23);
            this.refreshButtonLanguage.TabIndex = 31;
            this.refreshButtonLanguage.Text = "Refresh";
            this.refreshButtonLanguage.UseVisualStyleBackColor = true;
            this.refreshButtonLanguage.Click += new System.EventHandler(this.refreshButtonLanguage_Click);
            // 
            // MediaDataGridView
            // 
            this.MediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MediaDataGridView.Location = new System.Drawing.Point(802, 43);
            this.MediaDataGridView.Name = "MediaDataGridView";
            this.MediaDataGridView.Size = new System.Drawing.Size(694, 185);
            this.MediaDataGridView.TabIndex = 32;
            this.MediaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MediaDataGridView_CellClick);
            // 
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.Location = new System.Drawing.Point(802, 24);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(36, 13);
            this.Media.TabIndex = 33;
            this.Media.Text = "Media";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(802, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Selected Media";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "New Title";
            // 
            // newTitleTextBox
            // 
            this.newTitleTextBox.Location = new System.Drawing.Point(860, 262);
            this.newTitleTextBox.Name = "newTitleTextBox";
            this.newTitleTextBox.Size = new System.Drawing.Size(121, 20);
            this.newTitleTextBox.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(802, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Budget";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(860, 289);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(121, 20);
            this.budgetTextBox.TabIndex = 38;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(860, 341);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(121, 21);
            this.genreComboBox.TabIndex = 39;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(802, 347);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(36, 13);
            this.Language.TabIndex = 40;
            this.Language.Text = "Genre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(802, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Language";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(860, 369);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboBox.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(802, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Director";
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(860, 396);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(121, 21);
            this.directorComboBox.TabIndex = 44;
            // 
            // addMedia
            // 
            this.addMedia.Location = new System.Drawing.Point(805, 423);
            this.addMedia.Name = "addMedia";
            this.addMedia.Size = new System.Drawing.Size(176, 23);
            this.addMedia.TabIndex = 45;
            this.addMedia.Text = "Add Media";
            this.addMedia.UseVisualStyleBackColor = true;
            this.addMedia.Click += new System.EventHandler(this.addMedia_Click);
            // 
            // refreshButtonMedia
            // 
            this.refreshButtonMedia.Location = new System.Drawing.Point(805, 453);
            this.refreshButtonMedia.Name = "refreshButtonMedia";
            this.refreshButtonMedia.Size = new System.Drawing.Size(176, 23);
            this.refreshButtonMedia.TabIndex = 46;
            this.refreshButtonMedia.Text = "Refresh Media";
            this.refreshButtonMedia.UseVisualStyleBackColor = true;
            this.refreshButtonMedia.Click += new System.EventHandler(this.refreshButtonMedia_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(802, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Publish Year";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(874, 315);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(107, 20);
            this.publishYearTextBox.TabIndex = 48;
            // 
            // deleteButtonMedia
            // 
            this.deleteButtonMedia.Location = new System.Drawing.Point(805, 483);
            this.deleteButtonMedia.Name = "deleteButtonMedia";
            this.deleteButtonMedia.Size = new System.Drawing.Size(176, 23);
            this.deleteButtonMedia.TabIndex = 49;
            this.deleteButtonMedia.Text = "Delete Selected Media";
            this.deleteButtonMedia.UseVisualStyleBackColor = true;
            this.deleteButtonMedia.Click += new System.EventHandler(this.deleteButtonMedia_Click);
            // 
            // updateMedia
            // 
            this.updateMedia.Location = new System.Drawing.Point(805, 512);
            this.updateMedia.Name = "updateMedia";
            this.updateMedia.Size = new System.Drawing.Size(176, 23);
            this.updateMedia.TabIndex = 50;
            this.updateMedia.Text = "Update Media";
            this.updateMedia.UseVisualStyleBackColor = true;
            this.updateMedia.Click += new System.EventHandler(this.updateMedia_Click);
            // 
            // adminReservedGridView
            // 
            this.adminReservedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminReservedGridView.Location = new System.Drawing.Point(1052, 284);
            this.adminReservedGridView.Name = "adminReservedGridView";
            this.adminReservedGridView.Size = new System.Drawing.Size(444, 184);
            this.adminReservedGridView.TabIndex = 51;
            // 
            // borrowGridView
            // 
            this.borrowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowGridView.Location = new System.Drawing.Point(1052, 514);
            this.borrowGridView.Name = "borrowGridView";
            this.borrowGridView.Size = new System.Drawing.Size(444, 182);
            this.borrowGridView.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1052, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "All reserved media";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1052, 493);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "All borrowed media";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(32, 671);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(148, 23);
            this.logoutButton.TabIndex = 55;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 715);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.borrowGridView);
            this.Controls.Add(this.adminReservedGridView);
            this.Controls.Add(this.updateMedia);
            this.Controls.Add(this.deleteButtonMedia);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.refreshButtonMedia);
            this.Controls.Add(this.addMedia);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.newTitleTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.MediaDataGridView);
            this.Controls.Add(this.refreshButtonLanguage);
            this.Controls.Add(this.addLanguage);
            this.Controls.Add(this.newLanguageTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LanguageGridView);
            this.Controls.Add(this.refreshButtonDirector);
            this.Controls.Add(this.addDirector);
            this.Controls.Add(this.newDirectorTextBox);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.directorGridView);
            this.Controls.Add(this.addGenre);
            this.Controls.Add(this.newGenreTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.refreshbuttonGenre);
            this.Controls.Add(this.genreGridView);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteSelectedUser);
            this.Controls.Add(this.updatePasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedUserLabel);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminReservedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Label selectedUserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.Button deleteSelectedUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.DataGridView genreGridView;
        private System.Windows.Forms.Button refreshbuttonGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newGenreTextBox;
        private System.Windows.Forms.Button addGenre;
        private System.Windows.Forms.DataGridView directorGridView;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.TextBox newDirectorTextBox;
        private System.Windows.Forms.Button addDirector;
        private System.Windows.Forms.Button refreshButtonDirector;
        private System.Windows.Forms.DataGridView LanguageGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newLanguageTextBox;
        private System.Windows.Forms.Button addLanguage;
        private System.Windows.Forms.Button refreshButtonLanguage;
        private System.Windows.Forms.DataGridView MediaDataGridView;
        private System.Windows.Forms.Label Media;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newTitleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.Button addMedia;
        private System.Windows.Forms.Button refreshButtonMedia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Button deleteButtonMedia;
        private System.Windows.Forms.Button updateMedia;
        private System.Windows.Forms.DataGridView adminReservedGridView;
        private System.Windows.Forms.DataGridView borrowGridView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button logoutButton;
    }
}