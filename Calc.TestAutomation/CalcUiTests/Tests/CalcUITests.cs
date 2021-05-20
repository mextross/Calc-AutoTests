using CalcUiTests.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CalcUiTests.Tests
{
    [TestClass]
    public class CalcUITests
    {
        private CustomWebDriver customDriver;
        private string calcEndpoint;
        private CalcHomePage homePageElement;
        private CustomWebDriver.DriverBrowser chosenBrowser;
        private CustomWebDriver.BrowserMode chosenBrowserMode;
        private SelectElement operatorDropdown;

        public CalcUITests()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
             calcEndpoint = configuration.GetSection("calcUIEndpoint").Value;
            homePageElement = new CalcHomePage();
            chosenBrowser = CustomWebDriver.DriverBrowser.Chrome;
            chosenBrowserMode = CustomWebDriver.BrowserMode.UIMode;
            customDriver = new CustomWebDriver(chosenBrowser, chosenBrowserMode);

        }

        [TestInitialize]
        public void TestInitialize()
        {
            customDriver.GoToURL(calcEndpoint);
        }

        [TestMethod]
        public void TestFirstInput()
        {
            IWebElement firstNumInput = customDriver.FindElement(homePageElement.leftNumberInput);
            customDriver.SendKeys(homePageElement.leftNumberInput, "1");
            string firstNumInputValue = firstNumInput.GetAttribute("value");
            Assert.AreEqual("1", firstNumInputValue);
            Thread.Sleep(2000);
        }

      //  [TestMethod]
        public void TestSecondInput()
        {
        //    IWebElement secondNumInput = customDriver.FindElement(homePageElement.secondNumberInput);
        //    customDriver.SendKeys(homePageElement.secondNumberInput, "2");
        //    string secondNumInputValue = secondNumInput.GetAttribute("value");
        //    Assert.AreEqual("2", secondNumInputValue);
        }

        [TestMethod]
        public void TestMultiply()
        {
            customDriver.SendKeys(homePageElement.leftNumberInput, "1");
            operatorDropdown = new SelectElement(customDriver.FindElement(homePageElement.operatorDropdown));
            operatorDropdown.SelectByValue("*");
            customDriver.SendKeys(homePageElement.rightNumberInput, "2");
            customDriver.ClickElement(homePageElement.calcBtn);
           

             string additionResult = customDriver.FindElement(homePageElement.resultText).GetAttribute("value");
            //string additionResult = customDriver.GetResultText(homePageElement.resultText);
            Assert.AreEqual("2", additionResult);
        }


        [TestCleanup]
        public void TearDownTest()
        {
            customDriver.Close();
        }


    }
}
