using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\HCRUDEasyMexendo3\test\UnitTestProject1\bin\Debug\netcoreapp2.0\");
            driver.Navigate().GoToUrl("http://localhost:56515/");
            Console.WriteLine("Test Completed !!!");
            Console.ReadKey();
        }
    }
}
