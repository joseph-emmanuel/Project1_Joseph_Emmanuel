using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryMember
    {
        #region public  Properties
        public string Name { get; private set; }
        public List<Media> borrowHistory;
        public List<Media> currentlyBorrowed;
        #endregion
        #region Constructor
        public LibraryMember(string _name)
        {
            this.Name = _name;
            borrowHistory = new List<Media>();
            currentlyBorrowed = new List<Media>();
        }
        #endregion
        #region Public Methods
        public string MemberInfo()
        {
            string toReturnString="";

            toReturnString += "\nName : " + Name+ "\nBorrowed History: ";
            for (int i = 0; i < borrowHistory.Count; i++)
            {
                toReturnString += borrowHistory[i].Title +"\n";
            }
            toReturnString += "\n Currently Borrowed: ";
            for (int i = 0; i < currentlyBorrowed.Count; i++)
            {
                toReturnString += currentlyBorrowed[i].Title+"\n";
            }

            return toReturnString;
        }
        public void ModifyField(string _newName)
        {
            Name = _newName;
        }
        public void AddMediaToHistory(Media media)
        {
            borrowHistory.Add(media);
        }

        public void AddMediaToBorrowedList(Media media)
        {
            currentlyBorrowed.Add(media);
        }

        public void RemoveMediaFromBorrowedList(Media media)
        {
            currentlyBorrowed.Remove(media);
        }
        #endregion
    }
}
