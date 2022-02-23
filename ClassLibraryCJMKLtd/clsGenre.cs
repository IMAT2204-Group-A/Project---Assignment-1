using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    [Serializable()]
    public class clsGenre 
    {
        protected int genreid;
        protected string genrename;

        public clsGenre(int genreID, string genreName)
        {
            this.genreid = genreID;
            this.genrename = genreName;
        }
        public int GenreID
        {
            get { return genreid; }
            set { value = genreid; }

        }
    }
}
