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

        public clsDVDGenre(int dvdID, int genreID)
        {
            this.dvdid = dvdID;
            this.genreid = genreID;
        }
        public int DVDID
        {
            get { return dvdid; }
            set { dvdid = value; }
        }
    }
}
