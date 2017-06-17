using DesignPatterns.CreationalPatterns.Singleton.Report;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            /// Imagine multi threads using the report...
            /// I just keep in this way to demonstrate the pattern.
            ProcessReport.Add("Starting the application.");
            ProcessReport.Add("Processing some data..");
            ProcessReport.Add("Finishing the process.");

            Console.WriteLine(ProcessReport.GetCompleteReport());
        }
    }
}
