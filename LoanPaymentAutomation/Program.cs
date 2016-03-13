using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.IO;

namespace LoanPaymentAutomation
{
    class Program
    {
        public static void Log()
        {
            string path = Path.GetFullPath("E:/Documents/Programs/C#/LoanPaymentAutomationTests") + "/" +
                DateTime.Now.ToString("MM_dd_yyyy_HH_mm") + "_Log.txt";

            try
            {
                if(!File.Exists(path))
                {
                    File.Create(path);
                }
            }
            catch (Exception ex)
            {
                //Log error
                string errorLogPath = @"E:/LoanPaymentAutomationTests.txt";
                File.AppendAllText(errorLogPath, Environment.NewLine + ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            //Initialize browser
            PropertiesCollection.driver = new FirefoxDriver();
            Console.WriteLine("Opened Browser");

            //Read File
            FileReader file = new FileReader();
            file.ReadFile("e:/Documents/Programs/C#/LoanPaymentAutomationTests/info.txt");

            //Navigate to Loan Site
            PropertiesCollection.driver.Navigate().GoToUrl(file.info(11));

            //Login through 2 pages
            LoginPage page1 = new LoginPage("user-id");
            SecureLoginPage page2 = page1.Login(file);

            //Make payments and submit
            AccountSummaryPage page3 = page2.Submit(file);
            MakeAPaymentPage page4 = page3.MakeAPayment();
            SpecialPaymentPage page5 = page4.SubmitPayment(file);
            PaymentPreviewPage page6 = page5.Next();
            page6.btnSubmit.Click();

            //Close browser
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");

            Log();
        }
    }
}
