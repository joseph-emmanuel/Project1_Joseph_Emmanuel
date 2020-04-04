using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryMember
    {
        #region Private Properties
        public string Name { get; private set; }
        #endregion
        #region Constructor
        public LibraryMember(string _name)
        {
            this.Name = _name;
        }
        #endregion
        #region Public Methods
        public string MemberInfo()
        {
            return "\nName : " + Name;
        }
        public void ModifyField(string _newName)
        {
            Name = _newName;
        }




        /*        
        *//*        public virtual string MemberInfo()
                {
                    var info = "Serial No. : " + SerialNumber + "\nTitle : " + Title + "\nType : " + MediaType + "\nNo. of times lent : " +
                        NumberOfTimesLent + "\nAvailable : " + ((IsBorrowed) ? "Yes" : "No") + "\nCurrently borrowed by : "
                        + NameOfBorrower + "\n";
                    return info;
                }*/
        #endregion
    }
}
