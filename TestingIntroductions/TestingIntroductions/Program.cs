using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingIntroductions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
          
            Thread.Sleep(5000);

            driver.Navigate().GoToUrl("https://www.google.co.in/");
            
            Thread.Sleep(2000);

            IWebElement SearchElement = driver.FindElement(By.Name("q"));

            SearchElement.SendKeys("microsoft c#");

            Thread.Sleep(1000);

            IWebElement ButtonElement = driver.FindElement(By.Name("btnK"));

            ButtonElement.Click();

            Thread.Sleep(2000);

            driver.Close();

            Console.Write("Test Case Ended:");
        }
    }
}
