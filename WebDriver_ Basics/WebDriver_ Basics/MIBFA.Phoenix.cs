using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using AutoItX3Lib;
using System.Runtime;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using WindowsInput.Native;
using WindowsInput;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace WebDriver__Basics
{
    public class Authentication
    {

        IWebDriver driver = new FirefoxDriver();

        public static int timeDelay = 16000;

        public static void Main(string[] args)

        {

            ////Console.WriteLine(args[0]);
            // //launch firefox              

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://qa.phoenix.resolvesp.com/");
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));

            AutoItX3 autoIt = new AutoItX3();
            autoIt.Send("{SHIFTDOWN}g{SHIFTUP}ugu{SHIFTDOWN}n{SHIFTUP}{TAB}{SHIFTDOWN}b{SHIFTUP}athobakae21");
            OpenQA.Selenium.Support.UI.WebDriverWait wait1 = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));
            autoIt.Send("{TAB}");
            autoIt.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

        }

        //[SetUp]
        //public void Initialise()
        //{

        //}

        ////Console.WriteLine("Testing");

        ////DOCUMENTS TO CAPTURE TEST 1
        [Test]

        public void DataCapture()

        
        {


            String firmNumber = "5M22520";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement dataCapture = driver.FindElement(By.Id("ui-id-1"));
            dataCapture.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement dataCaptureLink = driver.FindElement(By.LinkText("Documents To Capture"));
            dataCaptureLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement documentCapture = driver.FindElement(By.CssSelector(".c-datagrid-body > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(3) > td:nth-child(3)"));
            documentCapture.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement firmNumberField = driver.FindElement(By.Name("SearchFirmName"));
            firmNumberField.SendKeys(firmNumber);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            //// Key down functionality-------

            IWebElement dropDown = driver.FindElement(By.CssSelector("#ui-id-26"));
            dropDown.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            SelectElement oSelect = new SelectElement(driver.FindElement(By.CssSelector("#SelectedYear")));
            oSelect.SelectByText("2018");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement periodMonth = driver.FindElement(By.CssSelector("#SelectedMonth"));
            periodMonth.Click();

            new SelectElement(driver.FindElement(By.CssSelector("#SelectedMonth"))).SelectByText("10");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            new SelectElement(driver.FindElement(By.CssSelector("#SelectedPayday"))).SelectByText("Thursday");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement checkBox = driver.FindElement(By.CssSelector("#ReturnsTypes_1__isSelected"));
            checkBox.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement detailsTab = driver.FindElement(By.CssSelector("#ui-id-23"));
            detailsTab.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement MIPFfield = driver.FindElement(By.CssSelector("#CaptureModel_NewReturnTypes_0__FundList_0__Value"));
            ////MIPFfield.Click();//
            MIPFfield.Clear();
            MIPFfield.SendKeys("150");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement EIPFfield = driver.FindElement(By.CssSelector("#CaptureModel_NewReturnTypes_0__FundList_1__Value"));
            ////EIPFfield.Click();
            EIPFfield.Clear();
            EIPFfield.SendKeys("280");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement Total = driver.FindElement(By.CssSelector("#ReturnFundTotal_2"));
            Total.Clear();
            Total.SendKeys("430");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#CaptureDocumentButton")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            ////driver.FindElement(By.CssSelector("button.btn:nth-child(1)")).Click();

            driver.FindElement(By.CssSelector("button.btn:nth-child(2)")).Click();

        }

        [Test]

        public void CapturedDocument()
        {

            String firmNumber = "5M22520";

            ////CAPTURED DOCUMENTS TEST 2

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            //IWebElement dataCapture1 = driver.FindElement(By.Id("ui-id-1"));
            //dataCapture1.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement CapturedDocumentLink = driver.FindElement(By.LinkText("Captured Documents"));
            CapturedDocumentLink.Click();

            //driver.FindElement(By.CssSelector("#ui-id-2 > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(1) > div:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            IWebElement firmNumberField1 = driver.FindElement(By.Name("SearchFirmName"));
            firmNumberField1.SendKeys(firmNumber);

            IWebElement dropDown1 = driver.FindElement(By.CssSelector("#ui-id-28"));
            dropDown1.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#firmQuickRange > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > button:nth-child(1)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#ReturnTypes_1__isSelected")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#searchButton")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.Id("158720279")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.Id("deleteDocumentButton")).Click();
            
            ///driver.FindElement(By.Id("viewButton")).Click();
            
            driver.FindElement(By.Id("editButton")).Click();


            driver.FindElement(By.CssSelector("button.btn:nth-child(2)")).Click();


            ////UNMANAGEABLE/IRRELEVANT ERRORS TEST 3

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#ui-id-2 > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1) > div:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
            // select a return
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[3]/div/div/div[3]/table/tbody/tr[10]/td[1]")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.Id("viewDocumentButton")).Click();

            //driver.FindElement(By.Id("restoreDocumentButton")).Click();
        }

        [Test]

        public void Firms()

        {
            String firmNumber = "5M22520";

            ////FIRMS

            //Firm Details tab

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#ui-id-9 > div:nth-child(2) > a:nth-child(1) > div:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#ui-id-10 > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > div:nth-child(2)")).Click();
            ;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement firmNumberField2 = driver.FindElement(By.Name("SearchFirmName"));
            firmNumberField2.SendKeys(firmNumber);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement dropDown2 = driver.FindElement(By.CssSelector("#ui-id-23"));
            dropDown2.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#ui-id-43")).Click();

            driver.FindElement(By.CssSelector("#firmDetails_Firm > input:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("div.ui-dialog:nth-child(7) > div:nth-child(3) > div:nth-child(1) > button:nth-child(1)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#firmDetails_Address > input:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement addressLine4 = driver.FindElement(By.CssSelector("#Firm_Address4"));
            addressLine4.SendKeys("Test123");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            driver.FindElement(By.CssSelector("#SearchResult > div:nth-child(10) > div:nth-child(3) > div:nth-child(1) > button:nth-child(2)")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);



            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
        }




    }

}
    
    

