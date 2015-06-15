using DesignPatterns.BehavioralPatterns.NullObject.People;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.NullObject
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        private static CustomerFactory _customerFactory = new CustomerFactory();

        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();

            Person customer = _customerFactory.GetCustomerBy("Benetti");
            people.Add(customer);

            Person nullCustomer = _customerFactory.GetCustomerBy("InvalidName");
            people.Add(customer);

            foreach (var person in people)
            {
                Console.WriteLine(person.SayYourName());
            }

            Console.ReadKey();
        }
    }
}
