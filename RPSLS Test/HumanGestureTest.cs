using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace RPSLS_Test
{
    [TestClass]
    public class HumanGestureTest
    {
        [TestMethod]
        public void HumanRockTest()
        {
            //Arrange
            string expectedHumanGestureChoice = "rock";
            string actualHumanGestureChoice;

            //Act
            Human human = new Human();
            human.ChooseGesture("rock");
            actualHumanGestureChoice = human.humanGesture;

            //Assert
            Assert.AreEqual(expectedHumanGestureChoice, actualHumanGestureChoice);

        }
        [TestMethod]
        public void HumanPaperTest()
        {
            //Arrange
            string expectedHumanGestureChoice = "paper";
            string actualHumanGestureChoice;

            //Act
            Human human = new Human();
            human.ChooseGesture("paper");
            actualHumanGestureChoice = human.humanGesture;

            //Assert
            Assert.AreEqual(expectedHumanGestureChoice, actualHumanGestureChoice);

        }
        [TestMethod]
        public void HumanScissorsTest()
        {
            //Arrange
            string expectedHumanGestureChoice = "scissors";
            string actualHumanGestureChoice;

            //Act
            Human human = new Human();
            human.ChooseGesture("scissors");
            actualHumanGestureChoice = human.humanGesture;

            //Assert
            Assert.AreEqual(expectedHumanGestureChoice, actualHumanGestureChoice);

        }
        [TestMethod]
        public void HumanLizardTest()
        {
            //Arrange
            string expectedHumanGestureChoice = "lizard";
            string actualHumanGestureChoice;

            //Act
            Human human = new Human();
            human.ChooseGesture("lizard");
            actualHumanGestureChoice = human.humanGesture;

            //Assert
            Assert.AreEqual(expectedHumanGestureChoice, actualHumanGestureChoice);

        }
        [TestMethod]
        public void HumanSpockTest()
        {
            //Arrange
            string expectedHumanGestureChoice = "spock";
            string actualHumanGestureChoice;

            //Act
            Human human = new Human();
            human.ChooseGesture("spock");
            actualHumanGestureChoice = human.humanGesture;

            //Assert
            Assert.AreEqual(expectedHumanGestureChoice, actualHumanGestureChoice);

        }
    }
}
