using DesignPatterns.CreationalPatterns.Singleton.Report;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace DesignPatterns.Test.TDD.CreationalPatterns.Singleton
{
    [TestClass]
    public class ProcessReportTest
    {
        [TestMethod, TestCategory("Singleton")]
        public void Validade_Order_Of_Report_Messages()
        {
            ProcessReport.Add("Starting");
            ProcessReport.Add("Finishing");

            string expected = "StartingFinishing";
            string reportResult = ProcessReport.GetCompleteReport();
            Assert.AreEqual(expected, reportResult);
        }

        [TestMethod, TestCategory("Singleton")]
        public void Validade_Multi_Thread_Messages()
        {
            ProcessReport.Clear();

            var threadOne = new Thread(() => ProcessReport.Add("ThreadOne"));
            var threadTwo = new Thread(() => ProcessReport.Add("ThreadTwo"));

            threadTwo.Start();
            Thread.Sleep(100);
            threadOne.Start();
            Thread.Sleep(100);

            string expected = "ThreadTwoThreadOne";
            string reportResult = ProcessReport.GetCompleteReport();
            Assert.AreEqual(expected, reportResult);
        }
    }
}
