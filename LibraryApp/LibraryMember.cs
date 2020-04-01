using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class LibraryMember
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
/*        #region Public Methods
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
