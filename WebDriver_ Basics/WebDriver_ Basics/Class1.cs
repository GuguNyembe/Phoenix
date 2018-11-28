using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using AutoItX3Lib;
using System.Runtime;

//using OpenQA.Selenium.IAlert;

namespace WebDriver__Basics
{
    public class Authentication {


         

        public static void Main (string[] args)

        {
            //Console.WriteLine(args[0]);
            // launch firefox 
  
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://qa.phoenix.resolvesp.com/");
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 5));
           
            AutoItX3 autoIt = new AutoItX3();
            autoIt.Send("{SHIFTDOWN}g{SHIFTUP}ugu{SHIFTDOWN}n{SHIFTUP}{TAB}{SHIFTDOWN}b{SHIFTUP}athobakae21");
            OpenQA.Selenium.Support.UI.WebDriverWait wait1 = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 5));
            autoIt.Send("{TAB}");
            autoIt.Send("{ENTER}");













        }




    }
}
