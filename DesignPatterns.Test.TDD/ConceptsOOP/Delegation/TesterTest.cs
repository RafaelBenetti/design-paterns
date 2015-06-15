using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Delegation.Workers;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Delegation
{
    [TestClass]
    public class TesterTest
    {
        [TestMethod, TestCategory("Delegation")]
        public void Validate_Tester_Work()
        {
            var jeanCarlo = new Tester();
            jeanCarlo.Work();
        }
    }
}
