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

        public string Valid(int orderID, int dvdID, int quantity)
        {
            string message = "";

            if (orderID < 1)
            {
                message = "orderID is too short";
            }

            if (orderID > 10000)
            {
                message = "orderID is too long";
            }

            return message;
        }
        public string ValidTwo(int dvdID, int orderID, int quantity)
        {
            string message = "";

            if (dvdID < 1)
            {
                message = "dvdID is too short";
            }

            if (dvdID > 10000)
            {
                message = "dvdID is too long";
            }

            return message;
        }

        public string ValidThree(int quantity, int orderID, int dvdID)
        {
            string message = "";

            if (quantity < 1)
            {
                message = "quantity is too little";
            }

            if (quantity > 100)
            {
                message = "quantity is too much";
            }

            return message;
        }

        public bool Find(int id)
        {
            return true;
        }
    }
}
