using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Emails;

namespace DesignPatterns.Test.TDD.BehavioralPatterns.TemplateMethod
{
    [TestClass]
    public class EmailGoogleTest
    {
        [TestMethod, TestCategory("Template Method")]
        public void Validate_Send_Google_Email()
        {
            EmailGoogle google = new EmailGoogle();
            google.SendEmail("templatemethod@gmail.com", "Hello dear!");
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Message can not be null.")]
        public void Validate_Send_Google_Email_Without_Message()
        {
            EmailGoogle google = new EmailGoogle();
            google.SendEmail("templatemethod@gmail.com", null);
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Recipient can not be null.")]
        public void Validate_Send_Google_Email_Without_Recipient()
        {
            EmailGoogle google = new EmailGoogle();
            google.SendEmail(null, "Hello dear!");
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), noExceptionMessage: "Invalid e-mail address.")]
        public void Validate_Send_Google_Email_Invalid_Address()
        {
            EmailGoogle google = new EmailGoogle();
            google.SendEmail("invalidaddress", "Hello dear!");
        }
    }
}
