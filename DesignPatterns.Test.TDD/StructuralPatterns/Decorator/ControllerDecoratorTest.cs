using DesignPatterns.StructuralPatterns.Decorator.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test.TDD.StructuralPatterns.Decorator
{
    [TestClass]
    public class ControllerDecoratorTest
    {
        [TestMethod, TestCategory("Decorator")]
        public void Validate_Decorator_Controller_Log()
        {
            IController controller = new HomeControllerDecorator();
            var response = controller.Request("ObjectOfRequest");
            var expected = "This is the response";

            Assert.AreEqual(expected, response);
        }
    }
}
