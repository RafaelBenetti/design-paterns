using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.OOP.Delegation.Workers
{
    public class Trainee : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I'm a Trainee...");
        }
    }
}
