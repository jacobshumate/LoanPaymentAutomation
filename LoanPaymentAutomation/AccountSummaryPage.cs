using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentAutomation
{
    public class AccountSummaryPage : PageInitialization
    {

        //Initialize Current Page Elements
        public AccountSummaryPage(string id) : base(id) {}

        [FindsBy(How = How.Id, Using = "btnMakePayment")]
        public IWebElement btnMakePayment { get; set; }

        //Click Make A Payment Button
        public MakeAPaymentPage MakeAPayment()
        {
            btnMakePayment.Click();

            return new MakeAPaymentPage("txtAmount_0");
        }
    }
}
