using TestStack.White.UIItems.Finders;
using TestingFramework.Framework.Items;
using Testing.Utils;
using TestingFramework.Framework.Helpers;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTesting.Areas
{
    partial class ContextMenu
    {
        protected Window CalculatorWindow => WindowHelper.GetWindow(Constants.CALCULATOR_WINDOW);
        public TFMenuBar MainMenuBar => new TFMenuBar(SearchCriteria.ByAutomationId("MenuBar"), CalculatorWindow, "Main");
        public TFMenu ViewMenuItem(string viewName) => new TFMenu(SearchCriteria.ByText(viewName), CalculatorWindow, viewName);
        public TFPanel CalculatorPanel => new TFPanel(SearchCriteria.ByClassName("CalcFrame"), CalculatorWindow, "Main Panel");
    }
}
