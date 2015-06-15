using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Interface.Files;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Interface
{
    [TestClass]
    public class ImageTest
    {
        private Image _image;

        public ImageTest()
        {
            _image = new Image("penguin.png");
        }

        [TestMethod, TestCategory("Interface")]
        public void Validate_Open_Image()
        {
            _image.Open();
        }

        [TestMethod, TestCategory("Interface")]
        public void Validate_Print_Image()
        {
            _image.Print();
        }

        [TestMethod, TestCategory("Interface")]
        public void Validate_Edit_Image()
        {
            _image.Edit();
        }
    }
}
