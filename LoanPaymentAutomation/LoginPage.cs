using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace LoanPaymentAutomation
{
    class LoginPage
    {
        
        //Initialize Current Page Elements
        public LoginPage()
        {
            //Wait for page to load
            WebDriverWait _wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 0, 30));
            _wait.Until(d => d.FindElement(By.Id("user-id")));

            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-id")]
        public IWebElement txtUserID { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        public IWebElement btnLogin { get; set; }

        //Login Credentials
        public SecureLoginPage Login(FileReader fileObj)
        {
            txtUserID.SendKeys(fileObj.info(0));
            txtPassword.SendKeys(fileObj.info(1));
            btnLogin.Submit();

            return new SecureLoginPage();
        }
    }
}
