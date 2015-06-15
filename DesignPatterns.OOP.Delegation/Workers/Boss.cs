using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.OOP.Delegation.Workers
{
    public class Boss
    {
        // Delegation...
        private IWorker _developer;
        private IWorker _tester;
        private IWorker _trainee;

        public Boss()
        {
            _developer = new Developer();
            _tester = new Tester();
            _trainee = new Trainee();
        }
        
        public void Work()
        {
            Console.WriteLine("I'm a boss. Back to work now!");

            _developer.Work();
            _tester.Work();
            _trainee.Work();
        }
    }
}
