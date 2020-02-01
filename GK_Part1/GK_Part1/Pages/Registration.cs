using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GK_Part1.Pages
{
    class Registration
    {
        private IWebDriver _driver;

        public Registration(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Elements

        public IWebElement btnLogin => _driver.FindElement(By.ClassName("login"));
        public IWebElement txtEmail => _driver.FindElement(By.Id("email_create"));
        public IWebElement btnRegister => _driver.FindElement(By.Id("SubmitCreate"));
        public IWebElement txtFirstName => _driver.FindElement(By.Id("customer_firstname"));
        public IWebElement txtLastName => _driver.FindElement(By.Id("customer_lastname"));
        public IWebElement txtPswd => _driver.FindElement(By.Id("passwd"));
        public IWebElement txtAddy => _driver.FindElement(By.Id("address1"));
        public IWebElement txtCity => _driver.FindElement(By.Id("city"));
        public IWebElement ddState => _driver.FindElement(By.Id("id_state"));
        public IWebElement txtPost => _driver.FindElement(By.Id("postcode"));
        public IWebElement txtMobile => _driver.FindElement(By.Id("phone_mobile"));
        public IWebElement btnSubmitAcc => _driver.FindElement(By.Id("submitAccount"));

        #endregion

        #region Functions

        public void SelectLogin()
        {
            Thread.Sleep(3000);
            btnLogin.Click();
        }

        public void CaptureNewEmail(string emailAddy)
        {
            Thread.Sleep(5000);
            txtEmail.SendKeys(emailAddy);
            btnRegister.Click();
        }

        public void CompleteRegForm(string firstName, string lastName, string pswrd, string streetAddy, string cityName, string postCode, string mobileNum)
        {
            Thread.Sleep(5000);
            txtFirstName.SendKeys(firstName);
            txtLastName.SendKeys(lastName);
            txtPswd.SendKeys(pswrd);
            txtAddy.SendKeys(streetAddy);
            txtCity.SendKeys(cityName);

            var stateSelect = new SelectElement(ddState);
            stateSelect.SelectByIndex(2);

            txtPost.SendKeys(postCode);
            txtMobile.SendKeys(mobileNum);
            btnSubmitAcc.Click();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        #endregion
    }
}
