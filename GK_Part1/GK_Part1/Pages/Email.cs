using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GK_Part1.Pages
{
    class Email
    {
        private IWebDriver _driver;

        public Email(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Elements
        public IWebElement btnContactUs => _driver.FindElement(By.Id("contact-link"));
        public IWebElement ddSubject => _driver.FindElement(By.Id("id_contact"));
        public IWebElement txtMsg => _driver.FindElement(By.Id("message"));
        public IWebElement btnSubmit => _driver.FindElement(By.Id("submitMessage"));
        public IWebElement lblSent => _driver.FindElement(By.ClassName("alert alert-success"));
        

        #endregion

        #region Functions

        public void LoadContactUs()
        {
            Thread.Sleep(3000);
            btnContactUs.Click();
        }
        public void SendEmail(string msgText)
        {
            Thread.Sleep(5000);
            var subjectSelect = new SelectElement(ddSubject);
            subjectSelect.SelectByIndex(2);
            txtMsg.SendKeys(msgText);
            btnSubmit.Submit();
            Thread.Sleep(3000);
        }
        public bool EmailSent => lblSent.Displayed;


        #endregion
    }
}
