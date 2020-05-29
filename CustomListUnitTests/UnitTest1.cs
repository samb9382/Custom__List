using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TwoPositiveValues_returnPostiveSum()
        {
            //arrange 
            CustomList1<int> thing = new CustomList1<int>();
            int value1 = 7;
            int expected = 7;
            int actual;
            //act
            thing.Add(value2);
            actual = thing[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoPositiveValues_returnPostiveSum1()
        {
            //arrange 
            CustomList1<int> thing = new CustomList1<int>();
            int value1 = 7;
            int expected = 9;
            int actual;
            //act
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            thing.Add(value1);
            actual = thing.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
