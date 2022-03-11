using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{


    public class clsBasketItem
    {
        private Int32 mDVDID;
        public Int32 DVDID
        {
            get
            {
                return mDVDID;
            }

            set
            {
                mDVDID = value;
            }
        }

        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

        private decimal mSubTotal;
        public decimal SubTotal
        {
            get
            {
                return mSubTotal;
            }

            set
            {
                mSubTotal = value;
            }
        }
    }
}
