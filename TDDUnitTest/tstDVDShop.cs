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
