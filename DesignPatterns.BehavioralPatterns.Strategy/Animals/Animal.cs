using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Strategy.Animals
{
    public abstract class Animal : IAnimal
    {        
        protected int NumberOfLegs { get; set; }

        public abstract int GetNumberOfLegs();
    }
}
