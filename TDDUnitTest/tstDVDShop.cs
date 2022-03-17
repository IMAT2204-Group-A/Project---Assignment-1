using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCJMKLtd;

namespace TDDUnitTest
{
    [TestClass]
    public class tstDVDShop
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the dvd shop
            clsOrder aDVDShop = new clsOrder();
            Assert.IsNotNull(aDVDShop);
        }

        [TestMethod]
        public void InstanceTwoOk()
        {
            //create an instance of the dvd shop
            clsOrderLine aDVDShop = new clsOrderLine();
            Assert.IsNotNull(aDVDShop);
        }

        [TestMethod]
        //checking that the price is ok
        public void OrderIDOk()
        {
            //create an instance of the dvd shop
            clsOrderLine aDVDShop = new clsOrderLine();
            //setting the test data to one
            int testData = 1;
            aDVDShop.OrderID = testData;
            Assert.AreEqual(aDVDShop.OrderID, testData);
        }

        [TestMethod]
        //checking that the price is ok
        public void DVDIDOk()
        {
            //create an instance of the dvd shop
            clsOrderLine aDVDShop = new clsOrderLine();
            //setting the test data to one
            int testData = 1;
            aDVDShop.DVDID = testData;
            Assert.AreEqual(aDVDShop.DVDID, testData);
        }

        [TestMethod]
        //checking that the price is ok
        public void QuanitiyOk()
        {
            //create an instance of the dvd shop
            clsOrderLine aDVDShop = new clsOrderLine();
            //setting the test data to one
            int testData = 1;
            aDVDShop.Quantity = testData;
            Assert.AreEqual(aDVDShop.Quantity, testData);
        }


        [TestMethod]
        //checking that the price is ok
        public void PriceOk()
        {
            //create an instance of the dvd shop
            clsOrder aDVDShop = new clsOrder();
            //setting the test data to one
            decimal testData = 1m;
            aDVDShop.TotalPrice = testData;
            Assert.AreEqual(aDVDShop.TotalPrice, testData);
        }

        [TestMethod]
        //checking that the price is ok
        public void UserIDOk()
        {
            //create an instance of the dvd shop
            clsOrder aDVDShop = new clsOrder();
            //setting the test data to one
            int testData = 1;
            aDVDShop.UserID = testData;
            Assert.AreEqual(aDVDShop.UserID, testData);
        }

        [TestMethod]
        //checking that the order date is ok
        public void OrderDateOk()
        {
            //create an instance of the dvd shop
            clsOrder aDVDShop = new clsOrder();
            //setting the test data to now
            DateTime testData = DateTime.Now.Date;
            aDVDShop.OrderDate = testData;
            Assert.AreEqual(aDVDShop.OrderDate, testData);
        }

        [TestMethod]
        //checking that the status is ok
        public void StatusOk()
        {
            //create an instance of the dvd shop
            clsOrder aDVDShop = new clsOrder();
            //setting the test data to now
            string testData = "Pending";
            aDVDShop.Status = testData;
            Assert.AreEqual(aDVDShop.Status, testData);
        }

        [TestMethod]
        public void FindOk()
        {
            clsOrder aDVDShop = new clsOrder();
            int id = 1;
            bool isFound = aDVDShop.Find(id);
            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void FindTwoOk()
        {
            clsOrderLine aDVDShop = new clsOrderLine();
            int id = 1;
            bool isFound = aDVDShop.Find(id);
            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void ValidOk()
        {
            //instance of the bookshop
            clsOrder aDVDShop = new clsOrder();
            //setting the price
            decimal price = 1m;
            //setting the uers id
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(price, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void ValidTwoOk()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //setting the price
            int orderID = 1;
            //setting the uers id
            int dvdID = 1;
            //setting the status
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(orderID, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 1
            int testData = 1;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDMinMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 0
            int testData = 0;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "orderID is too short");
        }

        [TestMethod]
        public void OrderIDExtremeMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data -11
            int testData = -11;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "orderID is too short");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 2
            int testData = 2;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDMaxMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 9999
            int testData = 9999;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 10000
            int testData = 10000;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 10001
            int testData = 10001;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "orderID is too long");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 5000
            int testData = 5000; 
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 500000
            int testData = 500000;
            //setting the dvdid
            int dvdID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, dvdID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "orderID is too long");
        }

        [TestMethod]
        public void DVDIDExtremeMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data -2
            int testData = -2;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "dvdID is too short");
        }

        [TestMethod]
        public void DVDIDMinMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 0
            int testData = 0;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "dvdID is too short");
        }

        [TestMethod]
        public void DVDIDMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 1
            int testData = 1;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void DVDIDMinPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 2
            int testData = 2;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void DVDIDMaxMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 9999
            int testData = 9999;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void DVDIDMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 10000
            int testData = 10000;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void DVDIDMaxPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 10001
            int testData = 10001;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "dvdID is too long");
        }

        [TestMethod]
        public void DVDIDMid()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 5000
            int testData = 5000;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void DVDIDExtremeMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 1000044
            int testData = 1000044;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int quantity = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidTwo(testData, orderID, quantity);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "dvdID is too long");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data -111
            int testData = -111;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "quantity is too little");
        }

        [TestMethod]
        public void QuantityMinMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 0
            int testData = 0;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "quantity is too little");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 1
            int testData = 1;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 2
            int testData = 2;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 99
            int testData = 99;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 100
            int testData = 100;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 101
            int testData = 101;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "quantity is too much");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 50
            int testData = 50;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //instance of the bookshop
            clsOrderLine aDVDShop = new clsOrderLine();
            //testing the data 101111
            int testData = 101111;
            //setting the orderid
            int orderID = 1;
            //setting the quantity
            int dvdID = 1;
            //getting the validation for the message
            string message = aDVDShop.ValidThree(testData, orderID, dvdID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "quantity is too much");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            //instance of the bookshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 0
            decimal testData = 0m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Not enough dolla");
        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 0
            decimal testData = 0m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Not enough dolla");
        }

        [TestMethod]
        public void PriceMin()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 1
            decimal testData = 1m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 1.1
            decimal testData = 1.1m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 999
            decimal testData = 999m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 1000
            decimal testData = 1000m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 10001
            decimal testData = 10001m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too much dolla");
        }

        [TestMethod]
        public void PriceMid()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 500
            decimal testData = 500m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 919191
            decimal testData = 919191m;
            //setting the userid
            int userID = 1;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, userID, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too much dolla");
        }

        [TestMethod]
        public void UserIdExtremeMin()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data -0
            int testData = -0;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too small");
        }

        [TestMethod]
        public void UserIdMinMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 0
            int testData = 0;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too small");
        }

        [TestMethod]
        public void UserIdMin()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 1
            int testData = 1;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void UserIdMinPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 2
            int testData = 2;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void UserIdMaxMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            int testData = 9999;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void UserIdMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            int testData = 10000;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void UserIdMaxPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            int testData = 10001; 
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too big");
        }

        [TestMethod]
        public void UserIdMid()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            int testData = 5000;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void UserIdExtremeMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            int testData = 1000033;
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            string status = "Pending";
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, status);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Too big");
        }

        [TestMethod]
        public void StatusMin()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "aa";
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void StatusExtremeMin()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "0";
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Status is too short");
        }

        [TestMethod]
        public void StatusMinMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a";
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Status is too short");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "aaa";
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void StatusMaxMinusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a".PadRight(9);
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void StatusMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a".PadRight(10);
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a".PadRight(11);
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Status is too long");
        }

        [TestMethod]
        public void StatusMid()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a".PadRight(5);
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "");
        }
        [TestMethod]
        public void StatusExtremeMax()
        {
            //instance of the dvdshop
            clsOrder aDVDShop = new clsOrder();
            //testing the data 
            string testData = "a".PadRight(555);
            //setting the price
            decimal price = 1m;
            //setting the order date
            DateTime orderDate = DateTime.Now.Date;
            //setting the status 
            int userID = 1;
            //getting the validation for the message
            string message = aDVDShop.Valid(testData, price, orderDate, userID);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Status is too long");
        }

    }
}
