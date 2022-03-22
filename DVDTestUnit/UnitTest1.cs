using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCJMKLtd;

namespace DVDTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMethodOK()
        {
            clsDVDCollection AllDVDs = new clsDVDCollection();
            clsDVD TestItem = new clsDVD();

            Int32 PrimaryKey = 0;
            TestItem.DVDID = 1;
            TestItem.DVDName = "Name";
            TestItem.DVDDescription = "TestDescription";
            TestItem.DVDDateOfRelease = DateTime.Now.Date;
            TestItem.DVDLength = 1;
            TestItem.DVDPrice = 1.20m;
            TestItem.DVDImage = "/Images/Test";
            TestItem.SupplierID = 1;
            AllDVDs.ThisDVD = TestItem;
            PrimaryKey = AllDVDs.Add();
            TestItem.DVDID = PrimaryKey;
            AllDVDs.ThisDVD.Find(PrimaryKey);
            Assert.AreEqual(AllDVDs.ThisDVD, TestItem);
        }
        
    }
}
