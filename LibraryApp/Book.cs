using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book:Media
    {
        #region Public Properties
        public int PageCount { set; private get; }
        #endregion
        #region Constructor
        public Book(string _title, string _mediaType,int _pageCount) :base(_title, _mediaType)
        {
            this.PageCount = _pageCount;
        }
        #endregion
        #region public methods
        public override string MediaInfo()
        {
            return base.MediaInfo() + "Page count : " + this.PageCount;
        }
        #endregion
    }
}
