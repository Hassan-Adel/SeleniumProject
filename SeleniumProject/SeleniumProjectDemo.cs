using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class SeleniumProjectDemo
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void startBrowser()
        {
            //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }
        
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}