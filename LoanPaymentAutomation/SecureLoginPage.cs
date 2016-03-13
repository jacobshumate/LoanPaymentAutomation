using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentAutomation
{
    public class SecureLoginPage : PageInitialization
    {

        //Initialize Current Page Elements
        public SecureLoginPage(string id) : base(id) {}

        [FindsBy(How = How.Id, Using = "account-number")]
        public IWebElement txtAccountNumber { get; set; }

        [FindsBy(How = How.Id, Using = "dob1")]
        public IWebElement txtDOB1 { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        public IWebElement btnSubmit { get; set; }

        //Submit Account Number and Date of Birth
        public AccountSummaryPage Submit(FileReader fileObj)
        {
            txtAccountNumber.SendKeys(fileObj.info(2));
            txtDOB1.SendKeys(fileObj.info(3));
            btnSubmit.Click();

            return new AccountSummaryPage("btnMakePayment");
        }
    }
}
