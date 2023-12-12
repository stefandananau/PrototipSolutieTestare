using TechTalk.SpecFlow;
using Testing.Utils;
using TestingFramework.Framework.Helpers;

namespace CalculatorTesting.Hooks
{
    [Binding]
    public sealed class BeforeHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ProcessHelper.KillAll(Constants.CALCULATOR_PROCESS);
        }
    }
}