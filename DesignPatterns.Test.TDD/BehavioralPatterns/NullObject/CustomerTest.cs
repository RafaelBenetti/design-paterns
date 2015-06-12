using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.NullObject.Persons;

namespace Test.TDD.BehavioralPatterns.NullObject
{
    [TestClass]
    public class CustomerTest
    {
        private CustomerFactory _customerFactory;

        public CustomerTest()
        {
            this._customerFactory = new CustomerFactory();
        }

        [TestMethod]
        [TestCategory("Null Object")]
        public void Validate_Say_Your_Name()
        {
            var expectedMessage = "My name is Rafael.";
            Person customer = this._customerFactory.GetCustomerBy("Rafael");
            string message = customer.SayYourName();

            Assert.AreEqual(expectedMessage, message);
        }
    }
}
