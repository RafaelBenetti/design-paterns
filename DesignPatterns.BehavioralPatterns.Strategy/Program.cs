using DesignPatterns.BehavioralPatterns.Strategy.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    class Program
    {
        private static AnimalsManagement _animalsManagement = new AnimalsManagement();

        static void Main(string[] args)
        {
            List<Animal> animals = _animalsManagement.GetAll();

            foreach (var animal in animals)
            {
                Console.WriteLine("I'm an animal with {0} legs.", animal.GetNumberOfLegs());
            }

            Console.ReadKey();
        }
    }
}
