using TechTalk.SpecFlow;
using TestingFramework.Framework;

namespace CalculatorTesting.Hooks
{
    [Binding]
    public sealed class AfterHooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            ApplicationController.Get().StopApplication();
        }
    }
}