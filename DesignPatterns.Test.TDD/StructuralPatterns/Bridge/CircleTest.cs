using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns.Bridge.Colors;
using DesignPatterns.StructuralPatterns.Bridge.Shapes;

namespace DesignPatterns.Test.TDD.StructuralPatterns.Bridge
{
    [TestClass]
    public class CircleTest
    {
        private RedColor _redColor;
        private BlueColor _blueColor;

        private const string BLUE_COLOR = "blue";
        private const string RED_COLOR = "red";

        public CircleTest()
        {
            this._redColor = new RedColor();
            this._blueColor = new BlueColor();            
        }

        [TestMethod]
        public void Validate_Set_Blue_Color_Circle()
        {   
            var retangle = new Circle(_blueColor);
            retangle.Paint();

            Assert.AreEqual(BLUE_COLOR, retangle.Color);
        }

        [TestMethod]
        public void Validate_Set_Red_Color_Circle()
        {
            var retangle = new Circle(_redColor);
            retangle.Paint();

            Assert.AreEqual(RED_COLOR, retangle.Color);
        }
    }
}
