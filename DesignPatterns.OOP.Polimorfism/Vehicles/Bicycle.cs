using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Polimorfism.Vehicles
{
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I move like a bibycle...");
        }
    }
}
