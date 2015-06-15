using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Delegation.Workers;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Delegation
{
    [TestClass]
    public class TraineeTest
    {
        [TestMethod, TestCategory("Delegation")]
        public void Validate_Trainee_Work()
        {
            var arnold = new Trainee();
            arnold.Work();
        }
    }
}
