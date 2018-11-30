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

//using OpenQA.Selenium.IAlert;

namespace WebDriver__Basics
{
    public class Authentication
    {

        IWebDriver driver = new FirefoxDriver();

        public static int timeDelay = 16000;

        public static void Main(string[] args)

        {
            //Console.WriteLine(args[0]);
            // launch firefox 

            IWebDriver driver = new FirefoxDriver();
            String firmNumber = "5M22520";           

            driver.Navigate().GoToUrl("http://qa.phoenix.resolvesp.com/");
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));

            AutoItX3 autoIt = new AutoItX3();
            autoIt.Send("{SHIFTDOWN}g{SHIFTUP}ugu{SHIFTDOWN}n{SHIFTUP}{TAB}{SHIFTDOWN}b{SHIFTUP}athobakae21");
            OpenQA.Selenium.Support.UI.WebDriverWait wait1 = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));
            autoIt.Send("{TAB}");
            autoIt.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);
           // Console.WriteLine("Testing");
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

            // Key down functionality-------

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
            MIPFfield.Clear();
            MIPFfield.SendKeys("150");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement EIPFfield = driver.FindElement(By.CssSelector("#CaptureModel_NewReturnTypes_0__FundList_1__Value"));
            EIPFfield.Clear();
            EIPFfield.SendKeys("280");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            IWebElement Total = driver.FindElement(By.CssSelector("#ReturnFundTotal_2"));
            Total.Clear();
            Total.SendKeys("430");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeDelay);

            //IWebElement submitButton = driver.FindElement(By.LinkText("#CaptureDocumentButton"));
            //submitButton.Click();


        }

            


    }
        

    
    }

