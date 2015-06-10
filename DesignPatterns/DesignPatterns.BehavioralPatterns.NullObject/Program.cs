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
            var customer = _customerFactory.GetCustomerBy("Rafael");
            customer.SayYourName();

            customer = _customerFactory.GetCustomerBy("NullCustomer");
            customer.SayYourName();
            
            Console.ReadKey();
        }
    }
}
