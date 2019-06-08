using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AdminForm : Form
    {
        private UserLogic userlogic = new UserLogic();
        private MediaLogic mediaLogic = new MediaLogic();
        private MediaModel selectedMedia = null;
        private UserModel selectedUser = null;
        private MediaModel3 media3 = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminReservedGridView.DataSource = mediaLogic.ListReserve();
            RefreshReservedList();
            RefreshUserList();
            RefreshGenreList();
            RefreshDirectorList();
            RefreshLanguageList();
            RefreshMediaList();
            userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));

            MediaDataGridView.DataSource = mediaLogic.ListMedia();

            genreComboBox.DataSource = mediaLogic.ListGenre();
            genreComboBox.DisplayMember = "PairName";
            genreComboBox.ValueMember = "PairId";

            languageComboBox.DataSource = mediaLogic.ListLanguage();
            languageComboBox.DisplayMember = "PairName";
            languageComboBox.ValueMember = "PairId";

            directorComboBox.DataSource = mediaLogic.ListDirector();
            directorComboBox.DisplayMember = "PairName";
            directorComboBox.ValueMember = "PairId";

            borrowGridView.DataSource = mediaLogic.ListBorrow();
        }
                
        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)    //-1 is the header row
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of user models
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;

                selectedUser = users.ElementAt<UserModel>(row); //get from this position
            }
        }

        private void MediaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)    //-1 is the header row
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of user models
                List<MediaModel> media = (List<MediaModel>)MediaDataGridView.DataSource;

                selectedMedia = media.ElementAt<MediaModel>(row); //get from this position
            }
        }

        private void RefreshUserList()
        {
            userGridView.DataSource = userlogic.GetListOfUsers();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshGenreList()
        {
            genreGridView.DataSource = mediaLogic.ListGenre();
        }

        private void refreshButtonGenre_Click(object sender, EventArgs e)
        {
            RefreshGenreList();
        }

        private void RefreshDirectorList()
        {
            directorGridView.DataSource = mediaLogic.ListDirector();
        }

        private void refreshButtonDirector_Click(object sender, EventArgs e)
        {
            RefreshDirectorList();
        }

        private void RefreshLanguageList()
        {
            LanguageGridView.DataSource = mediaLogic.ListLanguage();
        }

        private void refreshButtonLanguage_Click(object sender, EventArgs e)
        {
            RefreshLanguageList();
        }

        private void RefreshMediaList()
        {
            MediaDataGridView.DataSource = mediaLogic.ListMedia();
        }

        private void refreshButtonMedia_Click(object sender, EventArgs e)
        {
            RefreshMediaList();
        }

        private void RefreshReservedList()
        {
            adminReservedGridView.DataSource = mediaLogic.ListReserve();
        }


        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            //TODO make sure it matches criteria
            if (selectedUser != null)
            {
                int rowsAffected = userlogic.UpdatePassword(newPasswordTextBox.Text, selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show(selectedUser.UserName + " password updated!");
                }
                else
                {
                    //didnt
                }
                RefreshUserList();
            }
        }

        private void updateMedia_Click(object sender, EventArgs e)
        {
            if (selectedMedia != null)
            {
                if (newTitleTextBox.Text == "")
                {
                    newTitleTextBox.Text = selectedMedia.MediaName;
                }
                if (genreComboBox.SelectedValue == "")
                {
                    genreComboBox.SelectedValue = selectedMedia.GenreName;
                }
                if (directorComboBox.SelectedValue == "")
                {
                    directorComboBox.SelectedValue = selectedMedia.Director;
                }
                if (languageComboBox.SelectedValue == "")
                {
                    languageComboBox.SelectedValue = selectedMedia.Language;
                }
                if (publishYearTextBox.Text == "")
                {
                    publishYearTextBox.Text = selectedMedia.PublishYear.ToString();
                }
                if (budgetTextBox.Text == "")
                {
                    budgetTextBox.Text = selectedMedia.Budget;
                }

                int rowsAffected = mediaLogic.UpdateMedia(selectedMedia.MediaId, newTitleTextBox.Text, (int)genreComboBox.SelectedValue, (int)directorComboBox.SelectedValue, (int)languageComboBox.SelectedValue, Int32.Parse(publishYearTextBox.Text), Decimal.Parse(budgetTextBox.Text));
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show("Changes have been made");
                }
                RefreshMediaList();

            }

        }

        private void deleteSelectedUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                int affectedRows = userlogic.DeleteUserByUserID(selectedUser.UserID, CurrentUser.UserLevel);
                //if affectedRows > 0, deleted some people, else didnt

                selectedUser = null;

                RefreshUserList();
            }
        }

        private void deleteButtonMedia_Click(object sender, EventArgs e)
        {
            if (selectedMedia != null)
            {
                int affectedRows = mediaLogic.DeleteMediaByMediaID(selectedMedia.MediaId);
                //if affectedRows > 0, deleted some people, else didnt

                selectedMedia = null;

                RefreshMediaList();
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            //get enumback out of datasource of combo box...
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);

            int affectedRows = userlogic.AddNewUser(userNameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
            //if affected rows > 0 , success!

            RefreshUserList();
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.AddNewGenre(newGenreTextBox.Text);
            //if affected rows > 0 , success!

            RefreshGenreList();
        }

        private void addDirector_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.AddNewDirector(newDirectorTextBox.Text);
            //if affected rows > 0 , success!

            RefreshDirectorList();
        }

        private void addLanguage_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.AddNewLanguage(newLanguageTextBox.Text);
            //if affected rows > 0 , success!

            RefreshLanguageList();
        }

        private void addMedia_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.AddNewMedia(newTitleTextBox.Text, (int)genreComboBox.SelectedValue, (int)directorComboBox.SelectedValue, (int)languageComboBox.SelectedValue, Int32.Parse(publishYearTextBox.Text), Int32.Parse(budgetTextBox.Text));
            RefreshMediaList();
        }
        
        //private void borrowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int row = e.RowIndex;
        //    if (row >= 0)
        //    {
        //        List<MediaModel3> medias = (List<MediaModel3>)borrowGridView.DataSource;

        //        media3 = medias[row];
        //    }

        //}

        private void RefreshBorrowList()
        {
            borrowGridView.DataSource = mediaLogic.ListBorrow();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = "";
            CurrentUser.UserLevel = 0;
            CurrentUser.UserID = 0;

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLogin));
            t.Start();
            Close();
        }
        private void OpenLogin()
        {
            Application.Run(new LoginForm());
        }
               
    }
}
