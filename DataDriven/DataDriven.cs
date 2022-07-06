using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpPractice
{
    
    public class DataDriven
    {

        [Test]
        [TestCase("Sun", "Day", "7/3/2022")]
        [TestCase("Mon", "Day", "7/4/2022")]
        [TestCase("Tues", "Day", "7/5/2022")]

        public void DataDrivenTestingUsingDataRow(string fName, string lName, string eDate)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.uitestpractice.com/Students/Create");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(2);
            driver.FindElement(By.Id("FirstName")).SendKeys(fName);
            driver.FindElement(By.Id("LastName")).SendKeys(lName);
            driver.FindElement(By.XPath("//input[@type='datetime']")).SendKeys(eDate);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.Quit();

        }

    }
}
