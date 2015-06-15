using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.OOP.Delegation.Workers
{
    public class Developer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I'm a Developer. Just more one coffee...");
        }
    }
}
