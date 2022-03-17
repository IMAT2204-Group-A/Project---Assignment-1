using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsDVDGenre
    {
        protected int dvdid;
        protected int genreid;
        

        

        public int DVDID
        {
            get { return dvdid; }
            set { dvdid = value; }
        }

        public int GenreID
        {
            get { return genreid; }
            set { genreid = value; }
        }
    }
}
