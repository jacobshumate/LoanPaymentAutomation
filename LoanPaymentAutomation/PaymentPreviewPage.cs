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
    public class PaymentPreviewPage : PageInitialization
    {

        //Initialize Current Page Elements
        public PaymentPreviewPage(string id) : base(id) {}

        [FindsBy(How = How.Id, Using = "btnSubmitPreview")]
        public IWebElement btnSubmit { get; set; }
    }
}
