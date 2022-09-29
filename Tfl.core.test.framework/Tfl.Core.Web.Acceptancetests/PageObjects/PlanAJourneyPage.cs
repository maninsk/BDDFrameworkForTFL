namespace Tfl.Core.Web.Acceptancetests.PageObjects
{
    using System;
    using OpenQA.Selenium.Support.UI;
    using Tfl.Core.Web.Acceptancetests.Helpers;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public  class PlanAJourneyPage
    {
        private DriverFacade _driverFacade;

        private WebDriverWait wait;

        private IWebDriver driver;


        public PlanAJourneyPage(DriverFacade driverFacade)
        {

            _driverFacade = driverFacade;

        }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement JourneyResultsElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement EarlierJourneysElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement LaterJourneysElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement EditJourneyElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement EditJourneyFromElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement EditJourneyToElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement UpdateJourneyElement { get; set; }

        public void ClickOnEditJourney()
        {
            EditJourneyElement.Click();
        }
        public void ClickOnUpdateJourney()
        {
            EditJourneyElement.Click();
        }

        public void TypeJourneyFrom(string from)
        {
            EditJourneyFromElement.SendKeys(from);
        }

        public void TypeJourneyTo(string to)
        {
            EditJourneyToElement.SendKeys(to);
        }
    }
}
