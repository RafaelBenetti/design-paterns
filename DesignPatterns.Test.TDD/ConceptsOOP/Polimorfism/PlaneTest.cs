﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Polimorfism.Vehicles;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Polimorfism
{
    [TestClass]
    public class PlaneTest
    {
        [TestMethod]
        [TestCategory("Polimorfism")]
        public void Validate_Move_Plane()
        {
            var expectedMove = "I move like a plane...";

            var plane = new Plane();
            var move = plane.Move();

            Assert.AreEqual(expectedMove, move);
        }
    }
}

