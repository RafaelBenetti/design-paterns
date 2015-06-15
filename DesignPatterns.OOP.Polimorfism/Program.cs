using DesignPatterns.OOP.Polimorfism.Vehicles;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Polimorfism
{
    [ExcludeFromCodeCoverage]
    class Program
    {        
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            vehicles.Add(new Car());
            vehicles.Add(new Bicycle());
            vehicles.Add(new Plane());

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Move());
            }

            Console.ReadKey();
        }
    }
}
