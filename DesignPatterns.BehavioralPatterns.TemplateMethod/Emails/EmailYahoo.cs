using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Emails
{
    public class EmailYahoo : EmailBase
    {
        protected override void ValidateRecipient(string recipient)
        {
            if (string.IsNullOrEmpty(recipient))
                throw new EmailException("Recipient can not be null. yahoo team.");
            ValidateEmail(recipient);
        }

        protected override void ValidateMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new EmailException("Message can not be null. yahoo team.");
        }
        
        protected override void Append()
        {
            Console.WriteLine("E-mail by Yahoo.");
        }
    }
}
