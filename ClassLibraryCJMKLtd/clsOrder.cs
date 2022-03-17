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

        private string mStatus;

        public string Status
        {
            get { return mStatus; }

            set { mStatus = value; }
        }
        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get { return mOrderDate; }

            set { mOrderDate = value; }
        }

        List<clsOrderLine> mOrderList = new List<clsOrderLine>();

        public List<clsOrderLine> OrderList
        {
            get { return mOrderList; }

            set { mOrderList = value; }
        }

        public void ProcessBasket(clsBasket ShoppingBasket)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //pass the data as parameters to the data layer

            DB.AddParameter("@OrderDate", DateTime.Now.Date);
            DB.AddParameter("@UserId", ShoppingBasket.UserID);
            DB.AddParameter("@Price", ShoppingBasket.TotalPrice);
            DB.AddParameter("@Status", "Pending");


            //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
            Int32 NewOrderNo;
            NewOrderNo = DB.Execute("sproc_tblOrder_Insert");

            Int32 Index = 0;
            Int32 Count = ShoppingBasket.Products.Count;
            while (Index < Count)
            {
                //reset the connection to the database
                DB = new clsDataConnection();
                DB.AddParameter("@OrderId", NewOrderNo);
                DB.AddParameter("@DVDID", ShoppingBasket.Products[Index].DVDID);
                DB.AddParameter("@Quantity", ShoppingBasket.Products[Index].Quantity);

                Int32 OrderNo = DB.Execute("sproc_tblOrderLine_Insert");
                Index++;
            }

        }
        public bool Find(int id)
        {
            return true;
        }

        public string Valid(decimal price, int userID, DateTime orderDate, string status)
        {
            //stroing a blank message
            string message = "";
            //if the price is bellow 0.01
            if (price < 1m)
            {
                //give this output
                message = "Not enough dolla";
            }
            //if the price is above 1000
            if (price > 1000m)
            {
                //give this message 
                message = "Too much dolla";
            }
            
            //returns the message either blank or Not enough dolla, Too much dolla
            return message;
        }

        public string Valid(int userID, decimal price, DateTime orderDate, string status)
        {
            //stroing a blank message
            string message = "";
            //if the price is bellow 1
            if (userID < 1)
            {
                //give this output
                message = "Too small";
            }
            //if the price is above 10000
            if (userID > 10000)
            {
                //give this message 
                message = "Too big";
            }
            //returns the message either blank or Not enough dolla, Too much dolla
            return message;
        }
        public string Valid(string testData, decimal price, DateTime orderDate, int userID)
        {
            string message = "";

            if (testData.Length < 2)
            {
                message = "Status is too short";
            }

            if (testData.Length > 10)
            {
                message = "Status is too long";
            }

            return message;
        }

        //public string Valid(DateTime orderDate, int userID, decimal price, string status)
        //{
        //    string message = "";

        //    if (orderDate "")
        //    {
        //        message = "Status is too short";
        //    }

        //    if (orderDate.Length > 10)
        //    {
        //        message = "Name is too long";
        //    }

        //    return message;
        //}

        public List<clsOrder> FilterByUserID(int Format)
        {
            List<clsOrder> mOrderList = new List<clsOrder>();
            //
            clsDataConnection dBConnection = new clsDataConnection();
            //
            dBConnection.AddParameter("@UserID", Format);
            //
            dBConnection.Execute("sproc_tblOrder_FilterByUserID");
            int Index = 0;
            int RecordCount = dBConnection.Count;

            //keep looking till all records are processed 
            while (Index < RecordCount)
            {
                //create a blank video game page
                clsOrder NewOrder = new clsOrder();
                //copy the data from the tabke to the RAM
                NewOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderID"]);
                NewOrder.TotalPrice = Convert.ToDecimal(dBConnection.DataTable.Rows[Index]["Price"]);
                NewOrder.UserID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["UserID"]);
                NewOrder.OrderDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["OrderDate"]);
                NewOrder.Status = Convert.ToString(dBConnection.DataTable.Rows[Index]["Status"]);
                //add a blank page to the array list
                mOrderList.Add(NewOrder);
                //increase the index
                Index++;
            }
            return mOrderList;
        }

        public List<clsOrder> SelectAll()
        {
            List<clsOrder> mOrderList = new List<clsOrder>();
            //
            clsDataConnection dBConnection = new clsDataConnection();
            //
            //
            dBConnection.Execute("sproc_tblOrder_SelectAll");
            int Index = 0;
            int RecordCount = dBConnection.Count;

            //keep looking till all records are processed 
            while (Index < RecordCount)
            {
                //create a blank video game page
                clsOrder NewOrder = new clsOrder();
                //copy the data from the tabke to the RAM
                NewOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderID"]);
                NewOrder.TotalPrice = Convert.ToDecimal(dBConnection.DataTable.Rows[Index]["Price"]);
                NewOrder.UserID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["UserID"]);
                NewOrder.OrderDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["OrderDate"]);
                NewOrder.Status = Convert.ToString(dBConnection.DataTable.Rows[Index]["Status"]);
                //add a blank page to the array list
                mOrderList.Add(NewOrder);
                //increase the index
                Index++;
            }
            return mOrderList;
        }
    }
}
