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
    public partial class MediaBrowser : Form
    {
        private MediaLogic mediaLogic;
        private MediaModel media = null;
        private MediaModel2 media2 = null;
        List<UserModel> users = new List<UserModel>();

        public MediaBrowser()            
        {
            mediaLogic = new MediaLogic();
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
            reservedGridView.DataSource = mediaLogic.ListReserveByUID(CurrentUser.UserID);
            userLabel.Text = "Username: " + CurrentUser.UserName;

            returnComboBox.DataSource = mediaLogic.ListReturn(CurrentUser.UserID);
            returnComboBox.DisplayMember = "PairName";
            returnComboBox.ValueMember = "PairId";
        }

        private void yearSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByPublishYear(Int32.Parse(publishYearTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia(); //if error, list everything
            }
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
        }

        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //get which row was selected
            //if user clicks column headers, row = -1, so ignore
            if (row >= 0)
            {
                //cast dataSource from object back into what we put it in as
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;

                //get the individual media selected
                media = medias[row];
                selectedMediaLabel.Text = "Selected Media: " + media.MediaName;
            }

        }

        private void reservedGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                List<MediaModel2> medias = (List<MediaModel2>)reservedGridView.DataSource;

                media2 = medias[row];
            }

        }

        private void titleSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByTitle(string.Copy(titleTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();
            }

        }

        private void genreSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByGenreName(string.Copy(genreTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();
            }
        }

        private void RefreshUserList()
        {
            reservedGridView.DataSource = mediaLogic.ListReserveByUID(CurrentUser.UserID);
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mediaLogic.ListBorrow(media.MediaId).Count <= 0)
                {
                    try
                    {
                        if (mediaLogic.ListReserve(media.MediaId).Count <= 0)
                        {
                            int affectedRows = mediaLogic.InsertReserve(CurrentUser.UserID, media.MediaId, DateTime.Today.ToString("dd/MM/yyyy"));                          //change this according to the computers date layout either dd/MM/yyyy or MM/dd/yyyy
                            MessageBox.Show("A reservation has been made");
                        }
                        else
                            MessageBox.Show(media.MediaName + " this media is already reserved");

                        RefreshUserList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please select a media");
                    }
                }
                else
                    MessageBox.Show(media.MediaName + " is not available for reservation");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a media");
            }

        }

        private void deleteSelectedReservation_Click(object sender, EventArgs e)
        {
        
            if (media2 != null)
            {
                if (media2.UID == CurrentUser.UserID)
                {
                    int affectedRows = mediaLogic.DeleteReserve(media2.RID);

                    media2 = null;
                }
                else
                    MessageBox.Show("This isn't your reservation");

                RefreshUserList();
            }
            else
                MessageBox.Show("Please select a media");
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

        private void borrowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mediaLogic.ListBorrow(media.MediaId).Count <= 0)
                {
                    DateTime todayDate = DateTime.Today;
                    string todaysDate = todayDate.ToString("dd/MM/yyyy");                                                               //change this according to the computers date layout either dd/MM/yyyy or MM/dd/yyyy
                    DateTime expDate = todayDate.AddDays(30);
                    string expiryDate = expDate.ToString("dd/MM/yyyy");                                                                 //change this according to the computers date layout either dd/MM/yyyy or MM/dd/yyyy

                    int affectedRows = mediaLogic.InsertBorrow(CurrentUser.UserID, media.MediaId, todaysDate, expiryDate);
                    MessageBox.Show("You have borrowed " + media.MediaName);

                    //NEED  CONDITION TO DELETE RESERVE
                    int affectedRows2 = mediaLogic.DeleteReserveOnReturn(media.MediaId);

                }
                else
                    MessageBox.Show(media.MediaName + " is already borrowed");

                returnComboBox.DataSource = mediaLogic.ListReturn(CurrentUser.UserID);
                returnComboBox.DisplayMember = "PairName";
                returnComboBox.ValueMember = "PairId";

                RefreshUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a media");
            }
        }
        
        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)returnComboBox.SelectedValue != null)
                {
                    int affectedRows = mediaLogic.DeleteBorrow((int)returnComboBox.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing to return");
            }
                
            returnComboBox.DataSource = mediaLogic.ListReturn(CurrentUser.UserID);
            returnComboBox.DisplayMember = "PairName";
            returnComboBox.ValueMember = "PairId";
            returnComboBox.Text = "";
        }
        

    }
}
