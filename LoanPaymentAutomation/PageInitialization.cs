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
    public class PageInitialization
    {
        //Initialize Current Page Elements
        public PageInitialization(string value)
        {
            //Wait for page to load
            WebDriverWait _wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 0, 30));
            _wait.Until(d => d.FindElement(By.Id(value)));

            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
