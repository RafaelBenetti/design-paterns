using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OOP.Encapsulation.Vehicles
{
    public class Car
    {
        public Car()
        {
            this._maximumSpeed = 280;
            this._numberOfWheels = 4;
        }

        //Encapsuling car's details.
        //Composition, objects in another objects.
        public Engine _engine;
        private double _maximumSpeed { get; set; }
        private int _numberOfWheels { get; set; }

        public int GetNumberOfWheels()
        {
            return _numberOfWheels;        
        }

        public double GetMaximumSpeed()
        {
            return _maximumSpeed;        
        }
    }
}
