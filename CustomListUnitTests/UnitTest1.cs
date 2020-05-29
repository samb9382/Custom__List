﻿using System;
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

        [TestMethod]

        public void Add_ValueAt_Index0() //int value of 5 expected at index 0
        {
            //Arrange
            CustomList1<int> thing = new CustomList1<int>();
            int expected = 5;

            //Act
            thing.Add(5);

            int actual = thing[0]; //c# indexer

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2() //int value 10 expected at index 1
        {
            //Arrange
            CustomList1<int> thing = new CustomList1<int>();
            int expected = 10;

            //Act
            thing.Add(5);
            thing.Add(10);


            int actual = thing[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
