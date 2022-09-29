namespace Tfl.Core.Web.Acceptancetests.PageObjects
{
    using OpenQA.Selenium.Support.UI;
    using Tfl.Core.Web.Acceptancetests.Helpers;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public  class JourneyResults
    {
        private DriverFacade _driverFacade;

        private WebDriverWait wait;

        private IWebDriver driver;

        public JourneyResults(DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
            
        }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement JourneyResultsFromElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement JourneyResultsToElement { get; set; }

        [FindsBy(How = How.XPath, Using = "username")]
        protected IWebElement JourneyResultsValidationMsgElement { get; set; }

        public string GetFromValue()
        {
            string fromMsg = JourneyResultsFromElement.Text.ToString();

            return fromMsg;
        }

        public string GetToValue()
        {
            string toMsg = JourneyResultsFromElement.Text.ToString();

            return toMsg;
        }

        public string GetValidationMsg()
        {
            string toMsg = JourneyResultsValidationMsgElement.Text.ToString();

            return toMsg;
        }

    }
}
