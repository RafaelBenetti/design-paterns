using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.OOP.Delegation.Workers
{
    public class Tester : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I'm a Tester. Oh no! More one bug...");
        }
    }
}
