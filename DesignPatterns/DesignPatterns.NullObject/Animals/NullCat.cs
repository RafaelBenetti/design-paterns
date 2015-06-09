using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.Animals
{
    public class NullCat : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("I'm not a cat yet. NullReferenceException");
        }
    }
}
