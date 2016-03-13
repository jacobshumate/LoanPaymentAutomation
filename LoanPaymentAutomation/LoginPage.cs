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
    public class LoginPage : PageInitialization
    {

        //Initialize Current Page Elements
        public LoginPage(string id) : base(id) {}

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

            return new SecureLoginPage("account-number");
        }
    }
}
