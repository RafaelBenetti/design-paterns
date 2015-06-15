using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Interface.Files;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Interface
{
    [TestClass]
    public class MP3Test
    {
        [TestMethod, TestCategory("Interface")]
        public void Validate_Open_MP3()
        {
            var mp3 = new MP3("muse.mp3");
            mp3.Open();
        }
    }
}
