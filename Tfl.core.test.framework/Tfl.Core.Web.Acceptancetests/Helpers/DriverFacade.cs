namespace Tfl.Core.Web.Acceptancetests.Helpers
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Support.UI;

   public  class DriverFacade
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public IWebDriver getDriver(string driverType)
        {
            if (_driver == null)
            {
                setDriver(driverType);
            }
            return _driver;
        }
        private void setDriver(string driverType)
        {
            switch (driverType)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;

                case "InternetExplorer":
                    _driver = new InternetExplorerDriver();
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;
            }
        }

        public void Quit()
        {
            _driver.Quit();
        }
    }
}
