using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Interface.Files;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Interface
{
    [TestClass]
    public class ImageTest
    {
        [TestMethod, TestCategory("Interface")]
        public void Validate_Open_Image()
        {
            var image = new Image();
            image.Open();
        }

        [TestMethod, TestCategory("Interface")]
        public void Validate_Print_Image()
        {
            var image = new Image();
            image.Print();
        }

        [TestMethod, TestCategory("Interface")]
        public void Validate_Edit_Image()
        {
            var image = new Image();
            image.Edit();
        }
    }
}
