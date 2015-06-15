using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Encapsulation.Vehicles
{
    public class Car
    {
        private Engine _engine;

        public Car()
        {
            _engine = new Engine();
        }

        public string Move()
        {
            _engine.Start();

            return "Starting engine, injecting gasoline...";
        }
    }
}
