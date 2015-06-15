using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Encapsulation.Vehicles
{
    public class Engine
    {
        public int Potency { get; set; }
        public int Power { get; set; }
        
        public void Start()
        {
            Console.WriteLine("Starting engine...");
        }
    }
}
