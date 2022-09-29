namespace Tfl.Core.Web.Acceptancetests.PageObjects
{
    using System;
    using System.Configuration;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using Tfl.Core.Web.Acceptancetests.Helpers;

    public class BasePage
    {
        protected WebDriverWait wait;
        private readonly DriverFacade _driverFacade;
        private IWebDriver _driver;


        public BasePage(DriverFacade driverFacade)
        {
            this._driverFacade = driverFacade;

        }
        public void WaitAndClick(IWebElement element)
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void GoToSite()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public WebDriverWait Wait()
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
    }
}
