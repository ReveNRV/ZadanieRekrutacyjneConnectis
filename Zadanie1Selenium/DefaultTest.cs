using OpenQA.Selenium.Chrome;
using System;

namespace Zadanie1Selenium
{
    public class DefaultTest : IDisposable
    {
        public ChromeDriver _driver;

        public DefaultTest()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl/");
            
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
