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



        public bool Find(Int32 GenreID)
        {
            clsDataConnection dBConnection = new clsDataConnection();
            dBConnection.AddParameter("@DVDID", DVDID);
            dBConnection.Execute("sproc_tblDVDGenre_FilterByDVDID");
            if (dBConnection.Count == 1)
            {
                dvdid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["DVDID"]);
                genreid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["GenreID"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
