using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises.MarioKart.Players;
using Exercises.MarioKart.Vehicles;
using Exercises.MarioKart.Equipments;
using System.Collections.Generic;

namespace DesignPatterns.Test.TDD.Exercises.Mario_Kart
{
    [TestClass]
    public class KartTest
    {
        [TestMethod, TestCategory("Mario Kart - Kart")]
        public void Validate_Player_Without_Equip()
        {
            var player = new Player("Mario Bross", PlayerLevelEnum.Advanced);
            var sonnar = new Sonnar(player);

            Assert.AreEqual(3 + (int)player.Level, sonnar.Velocity);            
        }

        [TestMethod, TestCategory("Mario Kart - Kart")]
        public void Validate_Player_With_Equip()
        {
            var player = new Player("Mario Bross", PlayerLevelEnum.Advanced);
            var equips = new List<IEquip>();
            equips.Add(new DragonLeatherTires());
            equips.Add(new EngineLavaBased());

            var sonnar = new Sonnar(player, equips);            
            Assert.AreEqual(18, sonnar.Velocity);
        }
    }
}
