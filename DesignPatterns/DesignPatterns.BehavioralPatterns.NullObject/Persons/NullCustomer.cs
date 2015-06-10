using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject.Persons
{
    public class NullCustomer : Person
    {
        public override void SayYourName()
        {
            Console.WriteLine("I'm not a valid customer, but you can call me Null Object!");
        }
    }
}
