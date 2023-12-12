using CalculatorTesting.Utils;
using TechTalk.SpecFlow;
using Testing.Pages;
using Testing.Utils;
using TestingFramework.Framework;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class ApplicationSteps
    {
        [Given("The calculator application is started")]
        public void GivenCalculatorApplicationStart()
        {
            ApplicationController.Get().StartApplication(ConfigReader.GetPath());
            var page = new StandardPage(Constants.CALCULATOR_WINDOW);
            page.WaitUntilDisplayed(Constants.WAIT_TIME);
        }
    }
}
