using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public abstract class Media
    {
        #region Public Properties 
        public string Title { get; private set;}
        public string MediaType { get; private set;}
        public int SerialNumber { get; private set; } = 1000;
        public int NumberOfTimesLent { get; private set; }
        public bool IsBorrowed { get; private set; }
        public string NameOfBorrower { get; private set; }
        #endregion
        #region Constructor
        public Media(string _title,string _mediaType)
        {
            this.Title = _title;
            this.MediaType = _mediaType;
            SerialNumber++;
            NumberOfTimesLent = 0;
            IsBorrowed = true;
            NameOfBorrower = null;
        }
        #endregion
        #region Public Methods
        public virtual string MediaInfo()
        {
            var info = "Serial No. : " + SerialNumber + "\nTitle : " + Title + "\nType : " + MediaType + "\nNo. of times lent : " +
                NumberOfTimesLent + "\nAvailable : " + ((IsBorrowed) ? "Yes" : "No") + "\nCurrently borrowed by : "
                + NameOfBorrower + "\n";
            return info;
        }

        public void LentMedia(string name)
        {
            NumberOfTimesLent++;
            IsBorrowed = false;
            NameOfBorrower = name;
        }

        public void ReturnMedia()
        {
            IsBorrowed = true;
            NameOfBorrower = "";
        }

        public void ModifyField(string _title,string _type)
        {
            Title = _title;
            MediaType = _type;
        }
        #endregion
    }
}
