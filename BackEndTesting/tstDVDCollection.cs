using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCJMKLtd;
using System.Collections.Generic;

namespace BackEndTesting
{
    [TestClass]
    public class tstDVDCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDVDCollection AllDVDs = new clsDVDCollection();
            Assert.IsNotNull(AllDVDs);
        }
        [TestMethod]
        public void DVDListOK()
        {
            /*
            clsDVDCollection AllDVDs = new clsDVDCollection();
            List<clsDVD> TestList = new List<clsDVD>();
            clsDVD TestItem = new clsDVD();

            TestItem.DVDName = "TestTest";
            TestItem.DVDDescription = "DescriptionTestTest";
            TestItem.DVDDateOfRelease = System.DateTime.Now;
            TestItem.DVDLenght = 1234;
            TestItem.DVDPrice = 22.3m;
            TestItem.SupplierID = 1;
            TestItem.DVDImage = "TestImage.com";
            TestItem.Add(TestItem);
            AllDVDs.DVDlist = TestList;
            Assert.AreEqual(AllDVDs.DVDlist, TestList)
            */
        }
    }
}
