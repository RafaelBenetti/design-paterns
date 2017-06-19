using System;

namespace DesignPatterns.StructuralPatterns.Decorator.Controller
{
    public class HomeController : IController
    {
        public string Request(string request)
        {
            Console.WriteLine("Making a simple request");
            return "This is the response";
        }        
    }
}
