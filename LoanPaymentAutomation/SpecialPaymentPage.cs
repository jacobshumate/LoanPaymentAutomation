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
    public class SpecialPaymentPage
    {
        public bool pageDisplayed = true;

        //Initialize Current Page Elements
        public SpecialPaymentPage()
        {
            //Wait for page to load
            try {
                WebDriverWait _wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 0, 30));
                _wait.Until(d => d.FindElement(By.Id("OverPaymentAhead_false")));
                PageFactory.InitElements(PropertiesCollection.driver, this);
            }
            catch
            {
                pageDisplayed = false;
            }
        }

        [FindsBy(How = How.Id, Using = "OverPaymentAhead_false")]
        public IWebElement txtNoOverPaymentAhead { get; set; }

        [FindsBy(How = How.ClassName, Using = "purple")]
        public IWebElement btnNext { get; set; }

        //Click No Advancement on due date and Next button
        public PaymentPreviewPage Next()
        {
            if (pageDisplayed)
            {
                txtNoOverPaymentAhead.Click();
                btnNext.Click();

                return new PaymentPreviewPage("btnSubmitPreview");
            }
            else
                return new PaymentPreviewPage("btnSubmitPreview");
        }
    }
}
