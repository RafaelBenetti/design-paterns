using DesignPatterns.CreationalPatters.AbstractFactory.Factory;
using DesignPatterns.CreationalPatters.AbstractFactory.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test.TDD.CreationalPatterns.AbstractFactory
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod, TestCategory("Abstract Factory")]        
        public void Validate_Reader_Instance_Pdf()
        {
            var reader = ReaderFactory.GetReader(ReaderTypeEnum.Pdf);
            Assert.IsInstanceOfType(reader, typeof(ReaderPdf));
        }

        [TestMethod, TestCategory("Abstract Factory")]
        public void Validate_Reader_Instance_Txt()
        {
            var reader = ReaderFactory.GetReader(ReaderTypeEnum.Txt);
            Assert.IsInstanceOfType(reader, typeof(ReaderTxt));
        }
    }
}
