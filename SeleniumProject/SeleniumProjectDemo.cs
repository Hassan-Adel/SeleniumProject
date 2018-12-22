using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            Random random = new Random();
            int randomData = random.Next(10000);
            string address = string.Format("qa{0:0000}@test.com", randomData);
            driver.Url = "http://demo.guru99.com/test/newtours/register.php";
            //Attach Elements
            IWebElement elementFirstname = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/input"));
            IWebElement elementLastname = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/input"));
            IWebElement elementPhone = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/input"));
            IWebElement elementEmail = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/input[@id='userName']"));
            IWebElement elementAddress = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/input"));
            IWebElement elementCity = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td[2]/input"));
            IWebElement elementState = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/input"));
            IWebElement elementPostalCode = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input"));
            IWebElement elementCountry = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/select"));
            //User info.
            IWebElement elementUsername = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input[@id='email']"));
            IWebElement elementPassword = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input"));
            IWebElement elementConfirmPassword = driver.FindElement(By.XPath("./html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[15]/td[2]/input"));

            //Set Elements
            elementFirstname.SendKeys(string.Format("Firstname{0:0000}", randomData));
            elementLastname.SendKeys(string.Format("Lastname{0:0000}", randomData));
            elementPhone.SendKeys(string.Format("012345{0:0000}", randomData));
            elementEmail.SendKeys(string.Format("qa{0:0000}@test.com", randomData));
            elementAddress.SendKeys(string.Format("Address{0:0000}", randomData));
            elementCity.SendKeys(string.Format("City{0:0000}", randomData));
            elementState.SendKeys(string.Format("State{0:0000}", randomData));
            elementPostalCode.SendKeys(string.Format("{0:0000}", randomData));

            elementUsername.SendKeys(string.Format("Username{0:0000}", randomData));
            elementPassword.SendKeys(string.Format("Password{0:0000}", randomData));
            elementConfirmPassword.SendKeys(string.Format("Password{0:0000}", randomData));


        }
        
        [TearDown]
        public void closeBrowser()
        {
            System.Threading.Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }

    }
}