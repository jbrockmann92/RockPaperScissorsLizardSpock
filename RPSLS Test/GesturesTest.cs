using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace RPSLS_Test
{
    [TestClass]
    public class GesturesTest
    {
        [TestMethod]
        public void TestGestures_ArrayLocations_Zero()
        {
            //Arrange
            string expectedResult = "rock";
            string humanActualResult;
            string computerActualResult;

            //Act
            Player player = new Human();
            Player computer = new Computer();
            humanActualResult = player.gestures[0];
            computerActualResult = player.gestures[0];

            //Assert
            Assert.AreEqual(expectedResult, humanActualResult);
            Assert.AreEqual(expectedResult, computerActualResult);
        }
        [TestMethod]
        public void TestGestures_ArrayLocations_One()
        {
            //Arrange
            string expectedResult = "paper";
            string humanActualResult;
            string computerActualResult;

            //Act
            Player player = new Human();
            Player computer = new Computer();
            humanActualResult = player.gestures[1];
            computerActualResult = player.gestures[1];

            //Assert
            Assert.AreEqual(expectedResult, humanActualResult);
            Assert.AreEqual(expectedResult, computerActualResult);
        }
        [TestMethod]
        public void TestGestures_ArrayLocations_Two()
        {
            //Arrange
            string expectedResult = "scissors";
            string humanActualResult;
            string computerActualResult;

            //Act
            Player player = new Human();
            Player computer = new Computer();
            humanActualResult = player.gestures[2];
            computerActualResult = player.gestures[2];

            //Assert
            Assert.AreEqual(expectedResult, humanActualResult);
            Assert.AreEqual(expectedResult, computerActualResult);
        }
        [TestMethod]
        public void TestGestures_ArrayLocations_Three()
        {
            //Arrange
            string expectedResult = "lizard";
            string humanActualResult;
            string computerActualResult;

            //Act
            Player player = new Human();
            Player computer = new Computer();
            humanActualResult = player.gestures[3];
            computerActualResult = player.gestures[3];

            //Assert
            Assert.AreEqual(expectedResult, humanActualResult);
            Assert.AreEqual(expectedResult, computerActualResult);
        }
        [TestMethod]
        public void TestGestures_ArrayLocations_Four()
        {
            //Arrange
            string expectedResult = "spock";
            string humanActualResult;
            string computerActualResult;

            //Act
            Player player = new Human();
            Player computer = new Computer();
            humanActualResult = player.gestures[4];
            computerActualResult = player.gestures[4];

            //Assert
            Assert.AreEqual(expectedResult, humanActualResult);
            Assert.AreEqual(expectedResult, computerActualResult);
        }
    }
}
