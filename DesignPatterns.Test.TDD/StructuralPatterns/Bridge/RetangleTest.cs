using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns.Bridge.Shapes;
using DesignPatterns.StructuralPatterns.Bridge.Colors;

namespace DesignPatterns.Test.TDD.StructuralPatterns.Bridge
{
    [TestClass]
    public class RetangleTest
    {
        private RedColor _redColor;
        private BlueColor _blueColor;

        private const string BLUE_COLOR = "blue";
        private const string RED_COLOR = "red";

        public RetangleTest()
        {
            this._redColor = new RedColor();
            this._blueColor = new BlueColor();            
        }

        [TestMethod, TestCategory("Bridge")]
        public void Validate_Set_Blue_Color_Retangle()
        {   
            var retangle = new Retangle(_blueColor);
            retangle.Paint();

            Assert.AreEqual(BLUE_COLOR, retangle.Color);
        }

        [TestMethod, TestCategory("Bridge")]
        public void Validate_Set_Red_Color_Retangle()
        {
            var retangle = new Retangle(_redColor);
            retangle.Paint();

            Assert.AreEqual(RED_COLOR, retangle.Color);
        }
    }
}
