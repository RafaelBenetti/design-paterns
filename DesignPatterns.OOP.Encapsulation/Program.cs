using DesignPatterns.OOP.Encapsulation.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Encapsulation
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            var corsa = new Car();

            // The car uses the engine to move, but the client does not need to know the motor.
            corsa.Move();           

            Console.ReadKey();
        }
    }
}
