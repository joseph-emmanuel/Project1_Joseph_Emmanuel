using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Magazine:Book
    {
        #region Public Properties
        public int IssueNumber { get; private set; }
        #endregion
        #region Cunstructor
        public Magazine(string _title, string _mediaType, int _pageCount,int _issueNumber) : base(_title, _mediaType,_pageCount)
        {
            this.IssueNumber = _issueNumber;
        }
        #endregion
    }
}
