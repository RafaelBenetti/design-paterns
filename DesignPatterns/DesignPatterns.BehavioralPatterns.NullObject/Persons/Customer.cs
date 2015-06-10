using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject.Persons
{
    public class Customer : Person
    {
        public Customer(string name)
        {
            this.Name = name;
        }

        public override void SayYourName()
        {
            Console.WriteLine(string.Format("My name is {0}.", base.Name));
        }
    }
}
