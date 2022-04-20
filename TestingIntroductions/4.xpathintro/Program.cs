using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.xpathintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://phptravels.com/demo");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//a[@href='//www.phptravels.net/admin']")).Click();

            Driver.FindElement(By.XPath("//a[contains(@href,'admin')]")).Click();
            Thread.Sleep(2000);
            //string currentwindows = Driver.WindowHandles;

            string p = Driver.WindowHandles[0];
            string c = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(c);

            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@name='email' and @type='text']")).SendKeys("admin@phptravels.com");

            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//input[@name='password' and @type='password']")).SendKeys("demoadmin");

            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            Thread.Sleep(3000);
            Driver.Close();
            Driver.Quit();
            



        }
    }
}
