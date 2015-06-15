using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject.People
{
    public abstract class Person : IPerson
    {
        protected string Name { get; set; }

        public abstract string SayYourName();
    }
}
