namespace Tfl.Core.Web.Acceptancetests.Helpers
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;


   public  class DriverFacade
    {
        private IWebDriver _driver;
        
        public IWebDriver GetDriver(string driverType)
        {
            if (_driver == null)
            {
                SetDriver(driverType);
            }
            return _driver;
        }
        private void SetDriver(string driverType)
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
