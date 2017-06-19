using DesignPatterns.StructuralPatterns.Decorator.Controller;
using System;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IController controller = new HomeControllerDecorator();
            controller.Request("requestObject");

            Console.ReadKey();
        }
    }
}
