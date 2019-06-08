using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class MediaModel
    {
        //propfull - tab, tab
        //attribute
        private int mediaId;
        //property (helps manage the attribute above)
        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        private string mediaName;

        public string MediaName
        {
            get { return mediaName; }
            set { mediaName = value; }
        }

        private int publishYear;

        public int PublishYear
        {
            get { return publishYear; }
            set { publishYear = value; }
        }

        private string genreName;

        public string GenreName
        {
            get { return genreName; }
            set { genreName = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private string language;

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        private string budget;

        public string Budget
        {
            get { return budget; }
            set { budget = value; }
        }
       
        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel media = new MediaModel();
            media.MediaId = mediaRow.MediaID;
            media.MediaName = mediaRow.Title;
            media.PublishYear = mediaRow.PublishYear;
            media.GenreName = mediaRow.GenreName;
            media.director = mediaRow.DirectorName;
            media.Language = mediaRow.LanguageName;
            media.Budget = mediaRow.Budget.ToString();
            return media;

        }
       
    }

public class MediaModel2
    {        
        private int mediaId;

        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private int uid;

        public int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private int rid;

        public int RID
        {
            get { return rid; }
            set { rid = value; }
        }
        
        public static MediaModel2 Parse(MediaDS.TabReservedRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel2 media = new MediaModel2();
            media.MediaId = mediaRow.MediaID;
            media.Date = mediaRow.ReservedDate.ToString("MM/dd/yyyy");
            media.UID = mediaRow.UID;
            media.RID = mediaRow.RID;
            return media;

        }
    }

public class MediaModel3
{
    private int mediaId;

    public int MediaId
    {
        get { return mediaId; }
        set { mediaId = value; }
    }

    private string returnDate;

    public string ReturnDate
    {
        get { return returnDate; }
        set { returnDate = value; }
    }

    private string borrowDate;

    public string BorrowDate
    {
        get { return borrowDate; }
        set { borrowDate = value; }
    }

    private int uid;

    public int UID
    {
        get { return uid; }
        set { uid = value; }
    }

    public static MediaModel3 Parse(MediaDS.TabBorrowRow mediaRow)
    {
        if (mediaRow == null)
            return null;

        MediaModel3 media = new MediaModel3();
        media.MediaId = mediaRow.MediaID;
        media.BorrowDate = mediaRow.BorrowDate.ToString("MM/dd/yyyy");
        media.ReturnDate = mediaRow.ReturnDate.ToString("MM/dd/yyyy");
        media.UID = mediaRow.UID;
        return media;

    }
}
}