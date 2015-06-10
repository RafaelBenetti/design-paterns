using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public class Elephant : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("I'm run like an Elephant.");
        }
    }
}
