using DesignPatterns.BehavioralPatterns.TemplateMethod.Emails;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            List<EmailBase> emails = new List<EmailBase>();
            emails.Add(new EmailGoogle());
            emails.Add(new EmailYahoo());

            foreach (var email in emails)
            {
                email.SendEmail("teste@gmail.com", "Hello dear!");
            }

            Console.ReadKey();
        }
    }
}
