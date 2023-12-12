using TechTalk.SpecFlow;
using Testing.Pages;
using Testing.Utils;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class ScientificCalculatorSteps
    {
        private ScientificPage page = new ScientificPage(Constants.CALCULATOR_WINDOW); 

        [When("I square the result")]
        public void WhenSquareResult()
        {
            page.SquareResult();
        }
    }
}