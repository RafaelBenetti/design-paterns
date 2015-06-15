using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Emails;

namespace DesignPatterns.Test.TDD.BehavioralPatterns.TemplateMethod
{
    [TestClass]
    public class EmailGoogleTest
    {
        private EmailGoogle _google;

        public EmailGoogleTest()
        {
            this._google = new EmailGoogle();
        }

        [TestMethod, TestCategory("Template Method")]
        public void Validate_Send_Google_Email()
        {
            _google.SendEmail("templatemethod@gmail.com", "Hello dear!");
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Message can not be null.")]
        public void Validate_Send_Google_Email_Without_Message()
        {
            _google.SendEmail("templatemethod@gmail.com", null);
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Recipient can not be null.")]
        public void Validate_Send_Google_Email_Without_Recipient()
        {
            _google.SendEmail(null, "Hello dear!");
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), noExceptionMessage: "Invalid e-mail address.")]
        public void Validate_Send_Google_Email_Invalid_Address()
        {
            _google.SendEmail("invalidaddress", "Hello dear!");
        }
    }
}
