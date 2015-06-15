using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Delegation.Workers;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Delegation
{
    [TestClass]
    public class DeveloperTest
    {
        [TestMethod, TestCategory("Delegation")]
        public void Validate_Developer_Work()
        {
            var benetti = new Developer();
            benetti.Work();            
        }
    }
}
