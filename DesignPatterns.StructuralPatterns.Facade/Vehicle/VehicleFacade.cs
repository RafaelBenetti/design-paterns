using System;
using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Facade.Vehicle
{
    public class VehicleFacade
    {
        private Car _car;
        private Engine _engine;
        private List<Accessory> _accessories;

        public VehicleFacade()
        {
            _car = new Car();
            _engine = new Engine();
            _accessories = new List<Accessory>();
        }

        public void CreateCompleteVehicle()
        {
            Console.WriteLine("Creating a specific Vehicle.");

            // Here you can do all the stuffs
            // Start the engine
            // Configure your accessories
        }
    }
}
