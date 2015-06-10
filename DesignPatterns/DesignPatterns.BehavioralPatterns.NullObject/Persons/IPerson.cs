using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject.Persons
{
    public abstract class Person
    {
        protected string Name { get; set; }
        public abstract void SayYourName();
    }
}
