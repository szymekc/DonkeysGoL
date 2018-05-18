using System;
using DonkeysGOL.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;

namespace DonkeysGOL.Tests.DonkeysGOL.Core.Tests
{
    [TestClass]
    public class SpaceTests
    {
        private Space space;
        private PrivateObject privObj;

        [TestInitialize]
        public void TestInitialize()
        {
            space = new Space(100);
            privObj = new PrivateObject(space);
        }

        [TestMethod]
        public void AdjustToSizeTooSmallElementTest()
        {
            var retVal = privObj.Invoke("adjustToSize", new object[]{-10, 100});
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(retVal, 90);
        }

        [TestMethod]
        public void AdjustToSizeTooBigElementTest()
        {
            var retVal = privObj.Invoke("adjustToSize", new object[] { 150, 100 });
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(retVal, 50);
        }

        [TestMethod]
        public void GetCellTest()
        {
            var retVal = privObj.Invoke("getCell", new object[] { 10, 10 });
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(retVal, space.SpaceArray[10, 10]);
        }

        [TestMethod]
        public void CountNeighborhoodTest()
        {
            for (int i = 1; i <= 3; ++i)
                for (int j = 1; j <= 3; ++j)
                    space.SpaceArray[i, j] = true;

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(8u, space.CountNeighborhood(2, 2));
        }


    }
}
