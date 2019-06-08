using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
        }

       
        public List<MediaModel> ListMedia()
        {
            //empty list of media models to start us off
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMedia();
            //for every row in the table returned -
            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                //create a model representing that row
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);//add it to our list of medias
            }

            return medias;
        }

        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByTitle(title);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByGenreName(string genreName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByGenreName(genreName);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByDirector(string Director)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByDirector(Director);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<PairModel> ListGenre()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabGenreDataTable genreTable = mediaDAO.ListGenre();

            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListLanguage()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabLanguageDataTable languageTable = mediaDAO.ListLanguage();

            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListDirector()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabDirectorDataTable directorTable = mediaDAO.ListDirector();

            foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListReturn(int UID)                                                       //new
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabReturnDataTable returnTable = mediaDAO.ListMediaByUID(UID);             

            foreach (MediaDS.TabReturnRow row in returnTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }
       
        public List<MediaModel2> ListReserve(int mediaID)
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserve();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                if (row.MediaID == mediaID)
                {
                    MediaModel2 media = MediaModel2.Parse(row);
                    medias.Add(media);
                }
            }

            return medias;
        }

        public List<MediaModel2> ListReserve()
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserve();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {               
                    MediaModel2 media = MediaModel2.Parse(row);
                    medias.Add(media);
            }

            return medias;
        }

        public List<MediaModel2> ListReserveByUID(int UID)
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListByUID(UID);

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                MediaModel2 media = MediaModel2.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        //BORROW
        public List<MediaModel3> ListBorrow(int mediaID)
        {
            List<MediaModel3> medias = new List<MediaModel3>();
            MediaDS.TabBorrowDataTable borrowTable = mediaDAO.ListBorrow();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {
                if (row.MediaID == mediaID)
                {
                    MediaModel3 media = MediaModel3.Parse(row);
                    medias.Add(media);
                }
            }

            return medias;
        }

        public List<MediaModel3> ListBorrow()
        {
            List<MediaModel3> medias = new List<MediaModel3>();
            MediaDS.TabBorrowDataTable borrowTable = mediaDAO.ListBorrow();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {
                MediaModel3 media = MediaModel3.Parse(row);
                medias.Add(media);
            }

            return medias;
        }





        //NEWWWWWWWWWWW

        public int AddNewGenre(string genreName)
        {
            return mediaDAO.InsertGenre(genreName);
        }
        public int AddNewDirector(string directorName)
        {
            return mediaDAO.InsertDirector(directorName);
        }
        public int AddNewLanguage(string languageName)
        {
            return mediaDAO.InsertLanguage(languageName);
        }
        public int AddNewMedia(string title, int genre, int director, int language, int publishYear, int budget)
        {
            return mediaDAO.InsertMedia(title,genre,director,language,publishYear,budget);
        }
        public int UpdateMedia(int mediaID, string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            return mediaDAO.UpdateMedia(mediaID, title, genre, director, language, publishYear, budget);
        }
        public int DeleteMediaByMediaID(int mediaID)
        {
            return mediaDAO.DeleteMediaByMediaID(mediaID);
        }
        // insert new reserve 
        public int InsertReserve(int UID, int mediaID, string date)
        {
            return mediaDAO.InsertReserve(UID, mediaID, date);
        }
        public int DeleteReserve(int RID)
        {
            return mediaDAO.DeleteReserve(RID);
        }
        public int DeleteReserveOnReturn(int MID)
        {
            return mediaDAO.DeleteReserveOnReturn(MID);                                              //new
        }
        // insert borrow
        public int InsertBorrow(int UID, int mediaID, string borDate, string retDate)
        {
            return mediaDAO.InsertBorrow(UID, mediaID, borDate, retDate);
        }
        public int DeleteBorrow(int BID)
        {
            return mediaDAO.DeletBorrow(BID);
        }
    }
}
