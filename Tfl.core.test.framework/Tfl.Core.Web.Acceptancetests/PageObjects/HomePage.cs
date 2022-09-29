namespace Tfl.Core.Web.Acceptancetests.PageObjects
{
    using System;
    using OpenQA.Selenium.Support.UI;
    using Tfl.Core.Web.Acceptancetests.Helpers;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;


    public class HomePage : BasePage
    {
        private DriverFacade _driverFacade;
        private IWebDriver driver;


        public HomePage(DriverFacade driverFacade) : base(driverFacade)
        {

            _driverFacade = driverFacade;

        }

        [FindsBy(How = How.XPath, Using = "//div[@class='logo']")]
        protected IWebElement HomeElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Plan a journey']")]
        protected IWebElement PlanAJourneyElement { get; set; }
       
        [FindsBy(How = How.Id, Using = "InputFrom")]
        protected IWebElement PlanAJourneyFromElement { get; set; }

        [FindsBy(How = How.Id, Using = "InputTo")]
        protected IWebElement PlanAJourneyToElement { get; set; }

        [FindsBy(How = How.Id, Using = "plan-journey-button")]
        protected IWebElement PlanMyJourneyElement { get; set; }

        [FindsBy(How = How.Id, Using = "InputFrom-error")]
        protected IWebElement InputFromErrorElement { get; set; }

        [FindsBy(How = How.Id, Using = "InputTo-error")]
        protected IWebElement InputToErrorElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='#jp-recent']")]
        protected IWebElement RecentElement { get; set; }

        public void IsHomeTabEnabled()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(driver => !driver.FindElement(By.XPath("")).Displayed);
        }

        public void ClickPlanAJourney()
        {
            PlanAJourneyElement.Click();
        }

        public void ClickPlanMyJourney()
        {
            PlanMyJourneyElement.Click();
        }

        public void ClickOnRecent()
        {
            RecentElement.Click();
        }

        public void TypeJourneyFrom(string from)
        {
            PlanAJourneyFromElement.SendKeys(from);
        }

        public void TypeJourneyTo(string to)
        {
            PlanAJourneyFromElement.SendKeys(to);
        }

        public string ErrorMessageFrom()
        {
            String fromErrMsg = PlanAJourneyFromElement.Text.ToString();

            return fromErrMsg;
        }

        public string ErrorMessageTo()
        {
            String toErrMsg =  PlanAJourneyFromElement.Text.ToString();

            return toErrMsg;
        }
    }
}
