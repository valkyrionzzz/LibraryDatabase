using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access.MediaDSTableAdapters;

namespace Data_Access
{
    //dao = data access object
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaTableAdapter; //read only
        private TabMediaTableAdapter MediaTableAdapter; //for data insert, delete, updates
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabDirectorTableAdapter directorTableAdapter;
        private TabReservedTableAdapter reserveTableAdapter;
        private TabBorrowTableAdapter borrowTableAdapter;
        private TabReturnTableAdapter returnTableAdapter;                                   //new

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaTableAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            MediaTableAdapter = new TabMediaTableAdapter();
            reserveTableAdapter = new TabReservedTableAdapter();
            borrowTableAdapter = new TabBorrowTableAdapter();
            returnTableAdapter = new TabReturnTableAdapter();                               //new
        }

        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaTableAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByTitle(string title)
        {
            viewMediaTableAdapter.FillByTitle(mediaDataSet.ViewMedia,title);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByGenreName(string genreName)
        {
            viewMediaTableAdapter.FillByGenreName(mediaDataSet.ViewMedia, genreName);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByDirector(string director)
        {
            viewMediaTableAdapter.FillByDirector(mediaDataSet.ViewMedia, director);
            return mediaDataSet.ViewMedia;
        }
        
        public MediaDS.TabDirectorDataTable ListDirector()
        {
            directorTableAdapter.Fill(mediaDataSet.TabDirector);
            return mediaDataSet.TabDirector;
        }

        public MediaDS.TabLanguageDataTable ListLanguage()
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }
        public MediaDS.TabGenreDataTable ListGenre()
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }                
        public MediaDS.TabReservedDataTable ListReserve()
        {
            reserveTableAdapter.Fill(mediaDataSet.TabReserved);
            return mediaDataSet.TabReserved;
        }
        public MediaDS.TabReservedDataTable ListByUID(int UID)
        {
            reserveTableAdapter.FillByUID(mediaDataSet.TabReserved, UID);
            return mediaDataSet.TabReserved;
        }
        public MediaDS.TabBorrowDataTable ListBorrow()
        {
            borrowTableAdapter.Fill(mediaDataSet.TabBorrow);
            return mediaDataSet.TabBorrow;
        }
        public MediaDS.TabReturnDataTable ListMediaByUID(int UID)
        {
            returnTableAdapter.Fill(mediaDataSet.TabReturn, UID);                    //new
            return mediaDataSet.TabReturn;           
        }
               
        public int InsertGenre(string genreName)
        {
            return genreTableAdapter.InsertGenre(genreName);
        }

        public int InsertLanguage(string languageName)
        {
            return languageTableAdapter.InsertLanguage(languageName);
        }

        public int InsertDirector(string directorName)
        {
            return directorTableAdapter.InsertDirector(directorName);
        }

        public int InsertMedia(string title, int genre, int director, int language, int publishYear, int budget)
        {            
            return MediaTableAdapter.InsertMedia(title, genre, director, language,publishYear,budget);
        }

        public int UpdateMedia(int mediaID, string title, int genre, int director, int language, int publishYear, decimal budget)
        {
            return MediaTableAdapter.UpdateMedia(title,genre,director,language,publishYear,budget,mediaID);
        }

        public int DeleteMediaByMediaID(int mediaID)
        {
            return MediaTableAdapter.DeleteMedia(mediaID);
        }

        //reservation
        public int InsertReserve(int UID, int mediaID, string date)
        {
            try
            {
                return reserveTableAdapter.InsertReserve(UID, mediaID, date);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteReserve(int RID)
        {
               return reserveTableAdapter.DeleteReserve(RID);   
        }

        public int DeleteReserveOnReturn(int MID)
        {
            return reserveTableAdapter.DeleteReserveOnReturn(MID);                                              //new
        }

        //borrow
        public int InsertBorrow(int UID, int mediaID, string borDate, string retDate)
        {
            try
            {
                return borrowTableAdapter.InsertBorrow(UID, mediaID, borDate, retDate);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeletBorrow(int BID)
        {
            return borrowTableAdapter.DeleteBorrow(BID);
        }
    }
}
