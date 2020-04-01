using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Movie:Media
    {
        #region Public Properties
        public double RunTime { set; private get; }
        #endregion
        #region Constructor
        public Movie(string _title, string _mediaType,double _runTime) :base(_title, _mediaType)
        {
            this.RunTime = _runTime;
        }
        #endregion
    }
}
