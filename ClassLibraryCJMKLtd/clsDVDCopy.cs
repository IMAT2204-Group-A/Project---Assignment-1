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


        

        public clsDVDCopy(int dvdCopyID, int dvdID, Condition condition)
        {
            this.dvdcopyid = dvdCopyID;
            this.dvdid = dvdID;
            this.condition = condition;
        }
        public int DVDCopyID
        {
            get { return dvdcopyid; }
            set { dvdcopyid = value; }
        }
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        };


    }


}
