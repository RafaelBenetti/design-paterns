using DesignPatterns.BehavioralPatterns.NullObject.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject
{
    class Program
    {
        private static CustomerFactory _customerFactory = new CustomerFactory();

        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();

            Person customer = _customerFactory.GetCustomerBy("Benetti");
            people.Add(customer);

            Person seller = _customerFactory.GetCustomerBy("Benetti");
            people.Add(customer);

            foreach (var person in people)
            {
                Console.WriteLine(person.SayYourName());
            }

            Console.ReadKey();
        }
    }
}
