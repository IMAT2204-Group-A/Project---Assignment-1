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
            decimal testData = 0.01m;
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
            decimal price = 0.01m;
            //setting the quantity
            int userID = 1;
            //
            DateTime orderDate = DateTime.Now.Date;
            //
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
            //testing the data 0.19
            decimal testData = 0m;
            //setting the quantity
            int userID = 1;
            string message = aDVDShop.Valid(testData, price);
            //getting the message from the class and comparing it with the validation
            Assert.AreEqual(message, "Not enough dolla");
        }
    }
}
