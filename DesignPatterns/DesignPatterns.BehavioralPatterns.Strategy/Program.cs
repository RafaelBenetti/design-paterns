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
            List<IAnimal> animals = _animalsManagement.GetAll();

            foreach (var animal in animals)
            {
                animal.Run();
            }

            Console.ReadKey();
        }
    }
}
