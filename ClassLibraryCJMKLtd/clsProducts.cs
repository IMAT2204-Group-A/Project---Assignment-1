using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsProducts
    {
        private int mDVDID;
        public int DVDID
        {
            get { return mDVDID; }
            set { mDVDID = value; }
        }

        private decimal mPrice;
        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public void Find(int DVDID) 
        {
            if(DVDID == 2)
            {
                mDVDID = 2;
                mPrice = 32m;
            }

            if (DVDID == 3)
            {
                mDVDID = 3;
                mPrice = 53m;
            }
        }
    }
}
