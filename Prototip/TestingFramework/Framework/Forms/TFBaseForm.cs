using System;
using TestingFramework.Framework.Helpers;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Forms
{
    public abstract class TFBaseForm
    {
        protected Window window;

        public TFBaseForm(string windowName)
        {
            window = WindowHelper.GetWindow(windowName);
        }

        public bool isDisplayed()
        {
            return window.IsCurrentlyActive;
        }

        public void WaitUntilDisplayed(int waitTime)
        {
            Waiter.WaitUntil(new Func<bool>(() => isDisplayed()), waitTime);
        }
    }
}
