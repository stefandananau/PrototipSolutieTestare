using System;
using Testing.Utils;
using TestingFramework.Framework;

namespace CalculatorTesting.Areas
{
    partial class ContextMenu
    {
        public void OpenMenu(string menuName)
        {
            MainMenuBar.FindMenuItem(menuName).Click();
        }

        public void SelectViewItem(string viewName)
        {
            ViewMenuItem(viewName).Click();
            Waiter.WaitUntil(new Func<bool>(()=> CalculatorPanel.IsVisible()), Constants.WAIT_TIME);
        }
    }
}
