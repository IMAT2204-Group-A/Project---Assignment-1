using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsOrderLine
    {
        private Int32 mOrderLineId;

        public Int32 OrderLineId
        {
            get { return mOrderLineId; }

            set { mOrderLineId = value; }
        }

        private Int32 mOrderID;

        public Int32 OrderID
        {
            get { return mOrderID; }

            set { mOrderID = value; }
        }

        private Int32 mDVDID;

        public Int32 DVDID
        {
            get { return mDVDID; }

            set { mDVDID = value; }
        }

        private Int32 mQuantity;

        public Int32 Quantity
        {
            get { return mQuantity; }

            set { mQuantity = value; }
        }
    }
}
