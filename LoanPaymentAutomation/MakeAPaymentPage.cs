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
    class MakeAPaymentPage
    {

        //Initialize Current Page Elements
        public MakeAPaymentPage()
        {
            //Wait for page to load
            WebDriverWait _wait = new WebDriverWait(PropertiesCollection.driver, new TimeSpan(0, 0, 30));
            _wait.Until(d => d.FindElement(By.Id("txtAmount_0")));
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "txtAmount_0")]
        public IWebElement txtAmount1 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_1")]
        public IWebElement txtAmount2 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_2")]
        public IWebElement txtAmount3 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_3")]
        public IWebElement txtAmount4 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_4")]
        public IWebElement txtAmount5 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_5")]
        public IWebElement txtAmount6 { get; set; }

        [FindsBy(How = How.Id, Using = "txtAmount_6")]
        public IWebElement txtAmount7 { get; set; }

        [FindsBy(How = How.Id, Using = "btnNext")]
        public IWebElement btnNext { get; set; }

        //Enter values for each loan and submit
        public SpecialPaymentPage SubmitPayment(FileReader fileObj)
        {
            txtAmount1.Clear();
            txtAmount1.SendKeys(fileObj.info(4));
            txtAmount2.Clear();
            txtAmount2.SendKeys(fileObj.info(5));
            txtAmount3.Clear();
            txtAmount3.SendKeys(fileObj.info(6));
            txtAmount4.Clear();
            txtAmount4.SendKeys(fileObj.info(7));
            txtAmount5.Clear();
            txtAmount5.SendKeys(fileObj.info(8));
            txtAmount6.Clear();
            txtAmount6.SendKeys(fileObj.info(9));
            txtAmount7.Clear();
            txtAmount7.SendKeys(fileObj.info(10));

            btnNext.Click();

            return new SpecialPaymentPage();
        }
    }
}
