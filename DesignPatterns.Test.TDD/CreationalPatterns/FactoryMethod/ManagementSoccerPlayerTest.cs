using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns.FactoryMethod.Players;

namespace DesignPatterns.Test.TDD.CreationalPatterns.FactoryMethod
{
    [TestClass]
    public class ManagementSoccerPlayerTest
    {
        private ManagementPlayer _managementSoccerPlayer;

        public ManagementSoccerPlayerTest()
        {
            _managementSoccerPlayer = new ManagementSoccerPlayer();
        }

        [TestMethod, TestCategory("Factory Method")]
        public void Validate_Get_Instance_Of_Soccer_Player()
        {
            Player soccerPlayer = _managementSoccerPlayer.CreatePlayer();
            Assert.IsInstanceOfType(soccerPlayer, typeof(SoccerPlayer));
        }
    }
}
