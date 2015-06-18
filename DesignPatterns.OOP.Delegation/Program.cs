using DesignPatterns.OOP.Delegation.Workers;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace DesignPatterns.OOP.Delegation
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            var tesser = new Boss();
            tesser.Work();

            Console.ReadKey();
        }
    }
}
