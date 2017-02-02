using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises.MarioKart.Players;

namespace DesignPatterns.Test.TDD.Exercises.Mario_Kart
{
    [TestClass]
    public class PlayerTest
    {
        const int BEGINNER_BONUS = 3;
        const int INTERMEDIATE_BONUS = 5;
        const int ADVANCED_BONUS = 6;

        [TestMethod, TestCategory("Mario Kart - Player")]
        public void Validate_Beginner_Bonus()
        {
            var player = new Player("Mario Bross", PlayerLevelEnum.Beginner);
            Assert.AreEqual((int)player.Level, BEGINNER_BONUS);
        }

        [TestMethod, TestCategory("Mario Kart - Player")]
        public void Validate_Intermediate_Bonus()
        {
            var player = new Player("Mario Bross", PlayerLevelEnum.Intermediate);
            Assert.AreEqual((int)player.Level, INTERMEDIATE_BONUS);
        }

        [TestMethod, TestCategory("Mario Kart - Player")]
        public void Validate_Advanced_Bonus()
        {
            var player = new Player("Mario Bross", PlayerLevelEnum.Advanced);
            Assert.AreEqual((int)player.Level, ADVANCED_BONUS);
        }

        [TestMethod, TestCategory("Mario Kart - Player")]
        [ExpectedException(typeof(InvalidNameException))]
        public void Validate_Required_Name()
        {
            var player = new Player(null, PlayerLevelEnum.Advanced);
        }
    }
}
