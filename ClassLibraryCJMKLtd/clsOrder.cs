using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsOrder
    {
        private Int32 mOrderId;

        public Int32 OrderId
        {
            get { return mOrderId; }

            set { mOrderId = value; }
        }

        private decimal mTotalPrice;

        public decimal TotalPrice
        {
            get { return mTotalPrice; }

            set { mTotalPrice = value; }
        }

        private Int32 mUserID;

        public Int32 UserID
        {
            get { return mUserID; }

            set { mUserID = value; }
        }

        private string mDeliveryAddress;

        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }

            set { mDeliveryAddress = value; }
        }

        private string mPostCode;

        public string PostCode
        {
            get { return mPostCode; }

            set { mPostCode = value; }
        }

        private string mCity;

        public string City
        {
            get { return mCity; }

            set { mCity = value; }
        }

        private string mStatus;

        public string Status
        {
            get { return mStatus; }

            set { mStatus = value; }
        }

        private Int32 mCardNo;

        public Int32 CardNo
        {
            get { return mCardNo; }

            set { mCardNo = value; }
        }


    }

}
