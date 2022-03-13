using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{

    public class clsDVDCopy
    {
        protected int dvdcopyid;
        protected int dvdid;
        protected Condition condition;



        public int DVDCopyID
        {
            get { return dvdcopyid; }
            set { dvdcopyid = value; }
        }
        public int DVDID
        {
            get { return DVDID; }
            set { DVDID = value; }
        }
        public Condition Condition1
        {
            get { return condition; }
            set { condition = value; }
        }
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        };


        public string Find(string Condition)
        {
            clsDataConnection dbConnection = new clsDataConnection();
            dbConnection.AddParameter("@Condition", Condition);
            dbConnection.Execute("sproc_tblDVDCopy_FilterByDVDCopyCondition");
            if (dbConnection.Count == 1)
            {
                dvdcopyid = Convert.ToInt32(dbConnection.DataTable.Rows[0]["@DVDCopyID"]);
                dvdid = Convert.ToInt32(dbConnection.DataTable.Rows[0]["@DVDID"]);
                Condition = Enum.GetName(typeof(Condition), condition);
            }
            return Condition;
        }


    }


}
