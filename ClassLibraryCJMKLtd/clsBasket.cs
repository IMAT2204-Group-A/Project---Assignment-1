using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryCJMKLtd
{

    

    public class clsBasket
    {
        List<clsBasketItem> mProducts = new List<clsBasketItem>();
        private Int32 mUserID;
        public Int32 UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        private string mCardNo;
        public string CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }

        private decimal mTotalPrice;
        public decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public List<clsBasketItem> Products
        {
            get
            {
                return mProducts;
            }
        }

        public void Checkout()
        {
            //create an instance of the order class
            clsOrder Order = new clsOrder();
            //invoke the ProcessCart method
            Order.ProcessBasket(this);
        }
    }
}
