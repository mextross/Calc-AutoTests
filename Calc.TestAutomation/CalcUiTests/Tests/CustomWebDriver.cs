using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Threading;


namespace CalcUiTests.Tests
{
   public class CustomWebDriver
    {
        public IWebDriver driver;
        public int retryInterval;
        public int retryCount;
        public ChromeOptions chromeOptions;
        public WebDriverWait wait;

        public CustomWebDriver(DriverBrowser chosenBrowser, BrowserMode chosenMode)
        {
            if (chosenBrowser == DriverBrowser.Chrome)
            {
                chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                if (chosenMode == BrowserMode.HeadlessMode)
                {
                    chromeOptions.AddArgument("--headless");
                }

                driver = new ChromeDriver(chromeOptions);
            }

            else if (chosenBrowser == DriverBrowser.InternetExplorer)
            {
                driver = new InternetExplorerDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }
            wait = new WebDriverWait(driver, new TimeSpan(30000));
        }

        public void GoToURL(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void Close()
        {
            driver.Close();
        }

           public void ClickElement(By element)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.TagName("iframe")));
            IWebElement ifr = driver.FindElement(By.TagName("iframe"));
            driver.SwitchTo().Frame(ifr);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            driver.FindElement(element).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
        }

        public void SendKeys(By element, String input)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            driver.FindElement(element).SendKeys(input);
        }
        public IWebElement FindElement(By element)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
            return driver.FindElement(element);
        }

        //public string GetText(By elem)
        //{
        //    //    //String text = String.Empty;
        //    //    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        //    //    //return text = driver.FindElement(element).Text;

        //    //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        //    //    driver.FindElement(element);
        //    //    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(element));


            //string additionResult = customDriver.FindElement(homePageElement.resultText).GetAttribute("value");



       //     IWebElement resultTextInputField = wait.Until<IWebElement>((d) =>
       //{
       //        // IWebElement element = d.FindElement(By.Id("result"));
       //        IWebElement element = d.FindElement(elem);
       //    if (element.Displayed &&
       //        element.GetAttribute("value") == null)
       //    {
       //        return element;
       //    }

       //    return null;
       //});
       //     return resultTextInputField.GetAttribute("value");
       // }

    public void GetResultText(By element)
        {
            //IWebElement elem = driver.FindElement(element);
            //new WebDriverWait(driver, new TimeSpan(0, 0, 30000))
            //   .Until(d => d.FindElement(element).Enabled
            //       && d.FindElement(element).Displayed
            //       && d.FindElement(element).GetAttribute("value") == null
            //   );

            //return elem.GetAttribute("value");
            //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            //  new WebDriverWait(driver, new TimeSpan(30000)).Until(d => d.FindElement(element).GetAttribute("value").Length!=0);
            //IWebElement elem = driver.FindElement(element);
            //if (elem.GetAttribute("value") != null)
            //{
            //    return elem.GetAttribute("value");
            //}
            //else
            ////    return null;
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(element, ""));
            //IWebElement elem = driver.FindElement(element);
            //return elem.GetAttribute("value");
        }

        //Driver Browser options
        public enum DriverBrowser
        {
            [Description("chromedriver.exe")]
            Chrome,
            [Description("IEDriverServer.exe")]
            InternetExplorer
        }

        //BrowserMode options
        public enum BrowserMode
        {
            UIMode,
            HeadlessMode
        }

        public string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public void TakeScreenshot(string screenshotName)
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                // ss.SaveAsFile(@"../../../../TestScreenshots/" + screenshotName + ".jpg", ScreenshotImageFormat.Png);
                ss.SaveAsFile(@"C:\Agent\TestScreenshots\" + screenshotName + ".jpg", ScreenshotImageFormat.Png);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
