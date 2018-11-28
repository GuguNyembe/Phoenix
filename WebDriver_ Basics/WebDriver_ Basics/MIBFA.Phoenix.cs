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

        public static void Main(string[] args)

        {
            //Console.WriteLine(args[0]);
            // launch firefox 

            IWebDriver driver = new FirefoxDriver();
            String firmNumber = "5M22520";
            String periodYear = "2018";

            driver.Navigate().GoToUrl("http://qa.phoenix.resolvesp.com/");
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));

            AutoItX3 autoIt = new AutoItX3();
            autoIt.Send("{SHIFTDOWN}g{SHIFTUP}ugu{SHIFTDOWN}n{SHIFTUP}{TAB}{SHIFTDOWN}b{SHIFTUP}athobakae21");
            OpenQA.Selenium.Support.UI.WebDriverWait wait1 = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 30));
            autoIt.Send("{TAB}");
            autoIt.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
           // Console.WriteLine("Testing");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            IWebElement dataCapture = driver.FindElement(By.Id("ui-id-1"));
            dataCapture.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            IWebElement dataCaptureLink = driver.FindElement(By.LinkText("Documents To Capture"));
            dataCaptureLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            IWebElement documentCapture = driver.FindElement(By.CssSelector(".c-datagrid-body > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(3) > td:nth-child(3)"));
            documentCapture.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            IWebElement firmNumberField = driver.FindElement(By.Name("SearchFirmName"));
            firmNumberField.SendKeys(firmNumber);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);

            // Key down functionality-------

            IWebElement dropDown = driver.FindElement(By.CssSelector("#ui-id-26"));
            dropDown.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);

            //IWebElement period = driver.FindElement(By.CssSelector("#SelectedYear"));
            //period.Click();

            SelectElement oSelect = new SelectElement(driver.FindElement(By.CssSelector("#SelectedYear")));
            oSelect.SelectByText("2018");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);

        
            //test
            //test
        }

            


    }
        

    
    }

