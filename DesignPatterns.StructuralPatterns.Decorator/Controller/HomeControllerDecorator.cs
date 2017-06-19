using System;

namespace DesignPatterns.StructuralPatterns.Decorator.Controller
{
    public class HomeControllerDecorator : IController
    {
        private IController _realInstance;

        public HomeControllerDecorator()
        {
            _realInstance = new HomeController();
        }

        public string Request(string request)
        {
            Console.WriteLine("Here you can log the resquest anywhere.");
            return _realInstance.Request(request);
        }
    }
}
