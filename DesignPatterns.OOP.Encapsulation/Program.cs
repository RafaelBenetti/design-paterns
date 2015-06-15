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
        static void Main(string[] args)
        {
            var corsa = new Car();
            corsa.Move();

            Console.ReadKey();
        }
    }
}
