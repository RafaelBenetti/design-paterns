using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.NullObject.Persons;

namespace DesignPatterns.Test.TDD.BehavioralPatterns.NullObject
{
    [TestClass]
    public class NullObjectTest
    {
        private CustomerFactory _customerFactory;

        public NullObjectTest()
        {
            this._customerFactory = new CustomerFactory();
        }

        [TestMethod]
        public void Validate_Say_Your_Name()
        {
            var expectedMessage = "I'm not a valid customer, but you can call me Null Object!";
            Person customer = this._customerFactory.GetCustomerBy("InvalidName");
            string message = customer.SayYourName();

            Assert.AreEqual(expectedMessage, message);
        }
    }
}
