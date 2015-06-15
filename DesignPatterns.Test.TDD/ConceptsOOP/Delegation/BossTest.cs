using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Delegation.Workers;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Delegation
{
    [TestClass]
    public class BossTest
    {
        [TestMethod, TestCategory("Delegation")]
        public void Validate_Boss_Work()
        {
            var tesser = new Boss();
            tesser.Work();
        }
    }
}
