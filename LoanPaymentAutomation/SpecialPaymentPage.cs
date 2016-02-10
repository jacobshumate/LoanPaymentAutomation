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
    class SpecialPaymentPage
    {
        //Initialize Current Page Elements
        public SpecialPaymentPage()
        {
            //Wait for page to load
            WebDriverWait _wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 0, 30));
            _wait.Until(d => d.FindElement(By.Id("OverPaymentAhead_false")));
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "OverPaymentAhead_false")]
        public IWebElement txtNoOverPaymentAhead { get; set; }

        [FindsBy(How = How.ClassName, Using = "purple")]
        public IWebElement btnNext { get; set; }

        //Click No Advancement on due date and Next button
        public PaymentPreviewPage Next()
        {
            txtNoOverPaymentAhead.Click();
            btnNext.Click();

            return new PaymentPreviewPage();
        }
    }
}
