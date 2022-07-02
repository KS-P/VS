using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using  SeleniumCSharpPractice.BaseClass;
[assembly:Parallelizable(ParallelScope.Children)] 
[assembly:LevelOfParallelism(1)]

namespace SeleniumCSharpPractice
{
    public class Tests : BaseTest
    {
        

        [Test,Category("Smoke Testing")]
        public void Test1()

        {
            IWebElement userName= driver.FindElement(By.Id("txtUsername"));
            userName.SendKeys("Admin");
              IWebElement passWord= driver.FindElement(By.Id("txtPassword"));
            passWord.SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        [Test,Category("Regression Testing")]
        public void Test2()

        {
            IWebElement userName = driver.FindElement(By.Id("txtUsername"));
            userName.SendKeys("admin");
            IWebElement passWord = driver.FindElement(By.Id("txtPassword"));
            passWord.SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
    }
}