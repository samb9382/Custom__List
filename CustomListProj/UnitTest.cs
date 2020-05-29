using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj

{ [TestClass ]
    class UnitTest
    {
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(5);
            

            int actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void TestMethod2()
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
    }
}
