using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCJMKLtd;
using System.Collections.Generic; 

namespace DVDTestUnit
{
    [TestClass]
    public class tstDVDCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsDVDCollection AllDVDs = new clsDVDCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllDVDs);
        }
        [TestMethod]
        public void DVDListOK()
        {
            //create an instance of the class
            clsDVDCollection AllDVDs = new clsDVDCollection();
            //create some test data to assign to the property
            List<clsDVD> TestList = new List<clsDVD>();
            //add an item to the list
            //create the item of thest data
            clsDVD TestItem = new clsDVD();
            //Set its properties
            TestItem.DVDID = 1;
            TestItem.DVDName = "TestName";
            TestItem.DVDDescription = "TestDescription";
            TestItem.DVDDateOfRelease = DateTime.Now.Date;
            TestItem.DVDLength = 222;
            TestItem.DVDPrice = 2.22m;
            TestItem.SupplierID = 1;
            TestItem.DVDImage = "DVDTest";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllDVDs.DVDlist = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllDVDs.DVDlist, TestList);
        }

        [TestMethod]
        public void ThisDVDPropertyOK()
        {
            //Create the instance of the class 
            clsDVDCollection AllDVDs = new clsDVDCollection();
            //Create some test data of the test object.
            clsDVD TestDVD = new clsDVD();
            //Set the properties for the test object.
            TestDVD.DVDID = 1;
            TestDVD.DVDName = "TestnameOK";
            TestDVD.DVDDescription = "TestDescriptionOK";
            TestDVD.DVDDateOfRelease = DateTime.Now.Date;
            TestDVD.DVDLength = 222;
            TestDVD.DVDPrice = 2.22m;
            TestDVD.SupplierID = 1;
            TestDVD.DVDImage = "DVDImageTest";
            //set the data to the property.
            AllDVDs.ThisDVD = TestDVD;
            //Test to see that the two values are the same.
            Assert.AreEqual(AllDVDs.ThisDVD, TestDVD);
        }

        [TestMethod]
        public void DVDIDOK()
        {
            clsDVD DVDShop = new clsDVD();
            int TestDVDID = 1;
            DVDShop.DVDID = TestDVDID;
            Assert.AreEqual(DVDShop.DVDID, TestDVDID);
        }
        [TestMethod]
        public void DVDNameOK()
        {
            clsDVD DVDShop = new clsDVD();
            string DVDName = "TestName";
            DVDShop.DVDName = DVDName;
            Assert.AreEqual(DVDShop.DVDName, DVDName);
        }

        [TestMethod]
        public void DVDDescriptionOK()
        {
            clsDVD DVDShop = new clsDVD();
            string DVDDescriptionTest = "TestDescription";
            DVDShop.DVDDescription = DVDDescriptionTest;
            Assert.AreEqual(DVDShop.DVDDescription, DVDDescriptionTest);
        }
        [TestMethod]
        public void DVDLengthOK()
        {
            clsDVD DVDshop = new clsDVD();
            Int32 DVDLength = 2;
            DVDshop.DVDLength = DVDLength;
            Assert.AreEqual(DVDshop.DVDLength, DVDLength);
        }
        [TestMethod]
        public void DVDPrice()
        {
            clsDVD DVDShop = new clsDVD();
            decimal DVDPriceTest = 2.22m;
            DVDShop.DVDPrice = DVDPriceTest;
            Assert.AreEqual(DVDShop.DVDPrice, DVDPriceTest);
        }
        [TestMethod]
        public void SupplierIDOK()
        {
            clsDVD DVDShop = new clsDVD();
            int SupplierIDTest = 1;
            DVDShop.SupplierID = SupplierIDTest;
            Assert.AreEqual(DVDShop.SupplierID, SupplierIDTest);
        }
        [TestMethod]
        public void DVDImageOk()
        {
            clsDVD DVDShop = new clsDVD();
            string DVDImageTest = "ImageTest";
            DVDShop.DVDImage = DVDImageTest;
            Assert.AreEqual(DVDShop.DVDImage, DVDImageTest);
        }


        [TestMethod]
        public void FindOK()
        {
            clsDVD DVDShop = new clsDVD();
            int ID = 19;
            bool isFound = DVDShop.Find(ID);
            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsDVD DVDShop = new clsDVD();
            string DVDNameTest = "DVDNameTest";
            string DVDDescription = "DVDDescTest";
            DateTime DVDDateOfRelease = DateTime.Now.Date;
            int DVDLength = 1;
            decimal DVDPrice = 1.11m;
            string message = DVDShop.DVDValid(DVDNameTest, DVDDescription, DVDLength, DVDPrice);
            Assert.AreEqual(message, "");
        }


    }
}
