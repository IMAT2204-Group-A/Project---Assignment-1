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
            get { return dvdid; }
            set { dvdid = value; }
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


        





        public bool Find(int DVDCopyID)
        {
            clsDVDCopy newDVDCopy = new clsDVDCopy();
            clsDataConnection dBConnection = new clsDataConnection();
            dBConnection.AddParameter("@DVDCopyID", DVDCopyID);
            dBConnection.Execute("sproc_tblDVDCopy_FilterByDVDCopyID");
            if (dBConnection.Count == 1)
            {
                dvdcopyid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["DVDCopyID"]);
                dvdid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["DVDID"]);
                string condition_name = Convert.ToString(dBConnection.DataTable.Rows[0]["Condition"]);
                if (condition_name == Convert.ToString(clsDVDCopy.Condition.poor))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.poor;
                }

                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.fair))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                }

                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.good))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.mint))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.mint;
                }
                return true;
            }
            else
            {
                return false;
            }

        }


    }


}
