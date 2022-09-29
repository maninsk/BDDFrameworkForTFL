namespace Tfl.Core.Web.Acceptancetests.PageObjects
{
    using Tfl.Core.Web.Acceptancetests.Helpers;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public  class JourneyResults
    {
        private DriverFacade _driverFacade;

        public JourneyResults(DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
            
        }

        [FindsBy(How = How.XPath, Using = "//div[1]/span[2]/strong[1]")]
        protected IWebElement JourneyResultsFromElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/span[2]/strong[2]")]
        protected IWebElement JourneyResultsToElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='notranslate']")]
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
