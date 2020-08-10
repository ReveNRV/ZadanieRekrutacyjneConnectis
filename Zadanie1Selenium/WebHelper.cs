using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace Zadanie1Selenium
{
    public static class WebHelper
    {
        public static ChromeDriver _driver;


        public static void Click(this By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 2, 0));
            IWebElement elem = wait.Until(ExpectedConditions.ElementToBeClickable(by));
            elem.Click();
        }

        public static void WaitToBeClickable(this By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 2, 0));
            IWebElement elem = wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static string GetColor(this By by)
        {
            string color = _driver.FindElement(by).GetCssValue("color");
            return color;
        }

        public static void MoveTo(this By by)
        {
            var elem = _driver.FindElement(by);
            Actions builder = new Actions(_driver);
            builder.MoveToElement(elem).Build().Perform();
        }

        public static void SetText(this By by, string text)
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 2, 0));
            wait.Until(ExpectedConditions.ElementExists(by));

            var element = _driver.FindElement(by);

            element.Clear();

            if (!string.IsNullOrEmpty(text))
                element.SendKeys(text);
        }

        public static int CountElements(this By by)
        {
            IList<IWebElement> elemList = _driver.FindElements(by);
            return elemList.Count;
        }

        public static bool CheckIfExists(this By by)
        {
            var ele = _driver.FindElement(by);
            return (ele != null) ? true : false;
        }
    }
}
