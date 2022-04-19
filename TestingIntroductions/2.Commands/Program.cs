using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Browser Command
            //2.Navigation Command
            //3.WebElement Command

            //------Methods

            //Click() ---------------- Click WebElement
            //IWebElement.Click();

            //SendKeys(String Value)  -----Send values To Web Element 
            //IWebElement.SendKeys("Debasish");

            //Close()   -------- terminate the Browser Object
            //IWebDriver.Close()

            //Dispose()  ------- Close All Browser Object End Session Safely 
            //IWebDriver.Dispose()

            //Quit()   ---------internaly Calles Dispose()
            //IWebDriver.Quit()

            //FindElement()---> Find one WebElement From WebPage using proprties  Xpath,Class,CssSelector,ID

            //IWebElement ISearchContext.FindElement(By.Xpath(xpathexpression))
            //Return type of FindElement method is IWebElement

            //FindElements() ---> Find Many WebElement From WebPage using proprties  Xpath,Class,CssSelector,ID

            //IWebElement ISearchContext.FindElement(By.Xpath(xpathexpression))
            //Return type of FindElement method is IWebElement

            //SwitchTo()----> Switch ti Frames,Windows.Alert,ActiveElement
            //ITargetLocator IWebDriver.SwitchTo()   return type is the target locator().

            //Manage() -->Windows Based operations like Maximize,Minimize
            //IOptions IWebDriver.Manage();






            //Submit() --->Submit Forms and data Will Send to the server
            //IWebDriver.FindElement(By.id()).Submit();


            //GetAttribute()--->Fatch Attribute From WebElement and Return string

            //String data=IWebDriver.FindElement(By.id()).GetAttribute("Attribute Name")

            //GetCssValue() -->return css Attribute of WebElement.



            //String Data=IWebDriver.FindElement(By.id()).GetCssValue("Css Attribute")




            //Text  --->Capture the Text from webElement,return String

            //String Data=Driver.FindElement(By.Id("a1")).Text;


            //Selected -->Get the Value Whether element is Selectd or Not
            //only for Radio button and CheckBox 

            //Boolean data = Driver.FindElement(By.Id("")).Selected;



            //Enabled -->Check Element is enabled or Not and Return Boolean.

            //Boolean DarKMode = Driver.FindElement(By.Id("")).Enabled;



            //Displayed --->It Will Check The DOM Element and will Return Bool

            //Boolean DarKMode = Driver.FindElement(By.Id("")).Displayed;

            //TagName  

            //String DarKMode = Driver.FindElement(By.Id("")).TagName;

            //Size

            //int DarKMode = Driver.FindElement(By.Id(""))Size.Height;
            //int DarKMode = Driver.FindElement(By.Id(""))Size.Width;



            //Location X,Y is Coordinates

            //int DarKMode = Driver.FindElement(By.Id(""))Location.X;
            //int DarKMode = Driver.FindElement(By.Id(""))Location.Y;

            IWebDriver Driver = new ChromeDriver();
            string email = "txmatest@gmail.com";
            string password = "#Txtest#123#";

            Driver.Navigate().GoToUrl("https://gmail.com");

            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.XPath("//input[@aria-label='Email or phone']")).SendKeys(email);

            Task.Delay(2000).Wait();

            Driver.FindElement(By.XPath("//*[text()='Next']")).Click();

            Task.Delay(2000).Wait();

            Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);

            Task.Delay(2000).Wait();

            Driver.FindElement(By.XPath("//*[text()='Next']")).Click();

            Task.Delay(2000).Wait();

            Driver.FindElement(By.XPath("(//a[@role='button'])[4]")).Click();

            Task.Delay(2000).Wait();

            Driver.FindElement(By.XPath("//*[text()='Sign out']")).Click();


            Task.Delay(120000).Wait();

            Driver.Close();
            Driver.Quit();


           



        }
    }
}
