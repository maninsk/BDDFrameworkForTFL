namespace Tfl.Core.Web.Acceptancetests.StepDefinition
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;
    using Tfl.Core.Web.Acceptancetests.Helpers;
   

    [Binding]
    public class PlanAJourneyWidgetSteps
    {
        private DriverFacade _driverFacade;
        private Pages _pages;
        private readonly Logger _logger;

        public PlanAJourneyWidgetSteps(Pages pages, DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
            _pages = pages;
            _logger = new Logger();
        }

        
        [Then(@"the journey details should be displayed")]
        public void ThenTheJourneyDetailsShouldBeDisplayed()
        {
            VerifyTheJourneyDeatils();
        }

        [Then(@"the user should be able to update ""(.*)"" and ""(.*)""")]
        public void ThenTheUserShouldBeAbleToUpdateAnd(string from, string to)
        {
            _pages.PlanAJourneyPage.ClickOnEditJourney();
            _pages.PlanAJourneyPage.TypeJourneyFrom(from);
            _pages.PlanAJourneyPage.TypeJourneyTo(to);
            _pages.PlanAJourneyPage.ClickOnUpdateJourney();
            VerifyTheJourneyDeatils();
        }

        [Then(@"the user should get the message for invalid inputs in journey result")]
        public void ThenTheUserShouldGetTheMessageForInvalidInputsInJourneyResult()
        {
            var actualMsg = _pages.JourneyResults.GetValidationMsg();

            Assert.AreEqual(actualMsg, "", "The journey result validation message not as expected");
        }

        [Then(@"the user should get the validation message")]
        public void ThenTheUserShouldGetTheValidationMessage()
        {
            string actualFromMsg = _pages.HomePage.ErrorMessageFrom();
            string actualToMsg = _pages.HomePage.ErrorMessageTo();
            Assert.AreEqual(actualFromMsg, "","The From field validation error meessage not as expected ");
            Assert.AreEqual(actualToMsg, "", "The To field validation error meessage not as expected ");
        }

        [Then(@"the user should be able to view the recent journey details")]
        public void ThenTheUserShouldBeAbleToViewTheRecentJourneyDetails()
        {
            _pages.HomePage.ClickOnRecent();
            VerifyTheJourneyDeatils();
        }

        public void VerifyTheJourneyDeatils()
        {
            Assert.AreEqual(_pages.JourneyResults.GetFromValue(), "", "The From field validation error meessage not as expected ");
            Assert.AreEqual(_pages.JourneyResults.GetToValue(), "", "The To field validation error meessage not as expected ");
        }
    }
}
