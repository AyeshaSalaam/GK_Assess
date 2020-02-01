using GK_Part1.Pages;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;

namespace GK_Part1
{
    public class WebAut : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;
            

            //Navigate to the website
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //Register new account
            Registration registration = new Registration(driver);
            registration.SelectLogin();
            registration.CaptureNewEmail("random" + registration.RandomNumber(100, 300).ToString() + "@gmail.com");
            registration.CompleteRegForm("Roger", "That", "123450", "random street", "citadel", "00000", "1234567890");

            //Send email
            Email email = new Email(driver);
            email.LoadContactUs();
            email.SendEmail("The End.");

            return email.EmailSent ? ExecutionResult.Passed : ExecutionResult.Failed;
        }
    }
}
