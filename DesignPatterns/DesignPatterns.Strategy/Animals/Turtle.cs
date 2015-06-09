using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Animals
{
    public class Turtle : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("I'm run like a turtle.");
        }
    }
}
