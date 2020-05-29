using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void TestMethod1() //int value of 5 expected at index 0
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(5);


            int actual = myList[0]; //c# indexer

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2() //int value 10 expected at index 1
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;

            //Act
            myList.Add(5);
            myList.Add(10);


            int actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(5);
            myList.Add(10);


            int actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void TestMethod4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            int actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]

        public void TestMethod5()//Checking capactiy
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>(25);
            int expected = 8;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

            int actual = myList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void TestMethod6()//Checking capactiy
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>(25);
            int expected = 5;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

            int actual = myList[0];


            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void TestMethod7()//Checking capactiy
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>(25);
            int expected = 25;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

            int actual = myList[4];


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Remove_ItemShifted()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);

            myList.Remove(5);

            int actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]


        public void TestMethod9()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(5);

            myList.Remove(5);


            int actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Check_Capacity()//Checking capactiy
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>(25);
            int expected = 8;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

            int actual = myList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void TestMethod10()//Checking capactiy
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>(25);
            int expected = 25;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

            int actual = myList[4];
            myList.Remove(25);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        //ToString method override tests
        [TestMethod]

        public void 
    }

}
