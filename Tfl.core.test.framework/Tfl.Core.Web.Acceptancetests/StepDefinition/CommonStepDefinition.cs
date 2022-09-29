namespace Tfl.Core.Web.Acceptancetests.StepDefinition
{
    using TechTalk.SpecFlow;
    using Tfl.Core.Web.Acceptancetests.Helpers;
    using Tfl.Core.Web.Acceptancetests.PageObjects;

    [Binding]
    public sealed class CommonStepDefinition
    {
        private DriverFacade _driverFacade;
        private Pages _pages;
        private Logger _logger;

        public CommonStepDefinition(Pages page)
        {
            _pages = page;
        }

        [BeforeScenario]
        public void Before()
        {
            _driverFacade = new DriverFacade();
            _pages.HomePage = new HomePage(_driverFacade);
            _pages.PlanAJourneyPage = new PlanAJourneyPage(_driverFacade);
        }

        [Given(@"the ""(.*)"" is loaded")]
        public void GivenTheUserEntersIntoTflSite(string page)
        {
            _pages.HomePage.GoToSite();
        }

        [Given(@"the ""(.*)"" tab clicked")]
        public void GivenTheUserClicksOnThePlanAJourneyTab(string tab)
        {

            _pages.HomePage.ClickPlanAJourney();
        }

        [Given(@"the ""(.*)"" is loaded with existing journey")]
        public void GivenTheIsLoadedWithExistingJourney(string p0)
        {
            _pages.HomePage.GoToSite();
            _pages.HomePage.ClickPlanAJourney();
            EnterJourneyDetails("","");
        }

        [Given(@"the ""(.*)"" is loaded with recent history list")]
        public void GivenTheIsLoadedWithRecentHistoryList(string p0)
        {
            _pages.HomePage.GoToSite();
            _pages.HomePage.ClickPlanAJourney();
            EnterJourneyDetails("", "");
        }

       
        [When(@"the user inputs ""(.*)"" and ""(.*)""")]
        public void WhenTheUserInputsAnd(string from, string to)
        {
            EnterJourneyDetails(from, to);
        }

        [When(@"the ""(.*)"" button clicked")]
        public void WhenTheButtonClicked(string buttonName)
        {
            ClickTheButton(buttonName);
        }

        [When(@"the user clicks on the ""(.*)"" button")]
        public void WhenTheUserClicksOnTheButton(string buttonName)
        {
            ClickTheButton(buttonName);
        }

        [When(@"the user clicks on ""(.*)"" link")]
        public void WhenTheUserClicksOnLink(string link)
        {
            ClickTheButton(link);
        }

        [When(@"the user clicked on ""(.*)"" tab")]
        public void WhenTheUserClickedOnTab(string tab)
        {
            ClickTheButton(tab);
        }

        public void EnterJourneyDetails(string source, string designation)
        {
            _pages.HomePage.TypeJourneyFrom(source);
            _pages.HomePage.TypeJourneyTo(designation);
            _pages.HomePage.ClickPlanMyJourney();
        }

        public void ClickTheButton(string buttonName)
        {
            if(buttonName.Contains("plan my journey"))
            {
                _pages.HomePage.ClickPlanMyJourney();

            }else if(buttonName.Contains("edit journey"))
            {
                _pages.PlanAJourneyPage.ClickOnEditJourney();

            }else
            {
                _pages.HomePage.ClickOnRecent();
            }
        }

            [AfterScenario()]
        public void After()
        {
            if (_driverFacade != null)
            {
                _driverFacade.Quit();
            }
        }
    }
}
