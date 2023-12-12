using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.Pages;
using Testing.Utils;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class StandardCalculatorSteps
    {
        private StandardPage page = new StandardPage(Constants.CALCULATOR_WINDOW);

        [When(@"I input ([0-9]*) into calculator")]
        public void WhenInputNumber(string digitPattern)
        {
            page.InputNumber(digitPattern);
        }

        [When("I store the displayed result to calculator memory")]
        public void WhenNumberStored()
        {
            page.AddResultToMemory();
        }

        [When("I add ([0-9]*) to current result")]
        public void WhenAddNumber(string digitPattern)
        {
            page.AddNumber(digitPattern);
        }

        [When("I add the number from calculator memory")]
        public void WhenAddFromMemory()
        {
            page.AddFromMemory();
        }

        [Then("([0-9]*) is displayed as result")]
        public void ThenNumberDisplayed(string displayedNumber)
        {
            Assert.AreEqual(displayedNumber, page.GetResult());
        }
    }
}