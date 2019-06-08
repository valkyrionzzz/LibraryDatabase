namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            this.userLabel = new System.Windows.Forms.Label();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.yearSearchButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreSearchButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reservedGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedReservation = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnComboBox = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User: ";
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(39, 57);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(734, 231);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Publish Year:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(531, 306);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishYearTextBox.TabIndex = 3;
            // 
            // yearSearchButton
            // 
            this.yearSearchButton.Location = new System.Drawing.Point(647, 304);
            this.yearSearchButton.Name = "yearSearchButton";
            this.yearSearchButton.Size = new System.Drawing.Size(126, 23);
            this.yearSearchButton.TabIndex = 4;
            this.yearSearchButton.Text = "Search";
            this.yearSearchButton.UseVisualStyleBackColor = true;
            this.yearSearchButton.Click += new System.EventHandler(this.yearSearchButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(39, 304);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(120, 23);
            this.listAllButton.TabIndex = 5;
            this.listAllButton.Text = "List All Media";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(39, 343);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 6;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title: ";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(530, 336);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // titleSearchButton
            // 
            this.titleSearchButton.Location = new System.Drawing.Point(647, 336);
            this.titleSearchButton.Name = "titleSearchButton";
            this.titleSearchButton.Size = new System.Drawing.Size(126, 23);
            this.titleSearchButton.TabIndex = 9;
            this.titleSearchButton.Text = "Search";
            this.titleSearchButton.UseVisualStyleBackColor = true;
            this.titleSearchButton.Click += new System.EventHandler(this.titleSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre: ";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(530, 367);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(101, 20);
            this.genreTextBox.TabIndex = 11;
            // 
            // genreSearchButton
            // 
            this.genreSearchButton.Location = new System.Drawing.Point(647, 365);
            this.genreSearchButton.Name = "genreSearchButton";
            this.genreSearchButton.Size = new System.Drawing.Size(126, 23);
            this.genreSearchButton.TabIndex = 12;
            this.genreSearchButton.Text = "Search";
            this.genreSearchButton.UseVisualStyleBackColor = true;
            this.genreSearchButton.Click += new System.EventHandler(this.genreSearchButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(530, 394);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(243, 23);
            this.reserveButton.TabIndex = 13;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Your reserved list";
            // 
            // reservedGridView
            // 
            this.reservedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedGridView.Location = new System.Drawing.Point(861, 57);
            this.reservedGridView.Name = "reservedGridView";
            this.reservedGridView.Size = new System.Drawing.Size(524, 231);
            this.reservedGridView.TabIndex = 15;
            this.reservedGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservedGridView_CellClick);
            // 
            // deleteSelectedReservation
            // 
            this.deleteSelectedReservation.Location = new System.Drawing.Point(861, 304);
            this.deleteSelectedReservation.Name = "deleteSelectedReservation";
            this.deleteSelectedReservation.Size = new System.Drawing.Size(524, 23);
            this.deleteSelectedReservation.TabIndex = 16;
            this.deleteSelectedReservation.Text = "Delete Reservation";
            this.deleteSelectedReservation.UseVisualStyleBackColor = true;
            this.deleteSelectedReservation.Click += new System.EventHandler(this.deleteSelectedReservation_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(39, 493);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(160, 23);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(531, 424);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(242, 23);
            this.borrowButton.TabIndex = 18;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnComboBox
            // 
            this.returnComboBox.FormattingEnabled = true;
            this.returnComboBox.Location = new System.Drawing.Point(864, 366);
            this.returnComboBox.Name = "returnComboBox";
            this.returnComboBox.Size = new System.Drawing.Size(258, 21);
            this.returnComboBox.TabIndex = 21;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(1161, 366);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(213, 23);
            this.returnButton.TabIndex = 22;
            this.returnButton.Text = "Return media";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Borrowed Media";
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 534);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.returnComboBox);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.deleteSelectedReservation);
            this.Controls.Add(this.reservedGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.genreSearchButton);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleSearchButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.yearSearchButton);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.userLabel);
            this.Name = "MediaBrowser";
            this.Text = "MediaBrowser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Button yearSearchButton;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button titleSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Button genreSearchButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView reservedGridView;
        private System.Windows.Forms.Button deleteSelectedReservation;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.ComboBox returnComboBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label6;
    }
}