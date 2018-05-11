using System;
using System.Configuration;

namespace lab3Selenium.Configuration
{
    public static class TestConfiguration
    {
        public static string Url { get; } = ConfigurationManager.AppSettings["Url"];

        public static string Email { get; } = ConfigurationManager.AppSettings["Email"];

        public static string Password { get; } = ConfigurationManager.AppSettings["Password"];

        public static int WaitTimeout { get; } = Convert.ToInt32(ConfigurationManager.AppSettings["WaitTimeout"]);

        public static string MailSubject { get; } = ConfigurationManager.AppSettings["MailSubject"];

        public static string Message { get; } = ConfigurationManager.AppSettings["Message"];

        public static string IncorrectEmail { get; } = ConfigurationManager.AppSettings["IncorrectEmail"];

        public static string ErrorMessageHeader { get; } = ConfigurationManager.AppSettings["ErrorMessageHeader"];

        public static int NumberOfMailsToCheck { get; } = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfMailsToCheck"]);
    }
}
