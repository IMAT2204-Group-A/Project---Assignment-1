using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCJMKLtd;
using System.Collections.Generic;

namespace DVDTestUnit
{
    [TestClass]
    public class tstDVDCopyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDVDCopyCollection AllDVDCopys = new clsDVDCopyCollection();
            Assert.IsNotNull(AllDVDCopys);
        }
        [TestMethod]
        public void DVDCopyListOK()
        {
            clsDVDCopyCollection AllDVDs = new clsDVDCopyCollection();
            List<clsDVDCopy> TestList = new List<clsDVDCopy>();
            clsDVDCopy TestItem = new clsDVDCopy();

            TestItem.DVDCopyID = 1;
            TestItem.DVDID = 1;
            TestItem.Condition1 = clsDVDCopy.Condition.poor;
            TestList.Add(TestItem);
            AllDVDs.DVDCopiess = TestList;
            Assert.AreEqual(AllDVDs.DVDCopiess, TestList);


        }
        [TestMethod]
        public void ThisDVDCopyPropertyOK()
        {
            clsDVDCopyCollection AllDVDCopies = new clsDVDCopyCollection();
            clsDVDCopy TestDVD = new clsDVDCopy();
            TestDVD.DVDCopyID = 1;
            TestDVD.DVDID = 1;
            TestDVD.Condition1 = clsDVDCopy.Condition.poor;
            AllDVDCopies.thisDVDCopy = TestDVD;
            Assert.AreEqual(AllDVDCopies.thisDVDCopy, TestDVD);
        }

       

    }
}
