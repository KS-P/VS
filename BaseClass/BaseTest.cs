using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpPractice.BaseClass
{
    public class BaseTest
    {
       public IWebDriver driver;
        [SetUp]
    public void Open()
        {

             driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }
        [TearDown]
     public void Close()
        {
            driver.Quit();  
        }


    }
}
