using System;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Helpers
{
    public static class WindowHelper
    {
        public static Window GetWindow(string windowName)
        {
            try
            {
                LogWriter.GetLogger().Debug("Captured window {windowName}", windowName);
                var window = ApplicationController.Get().GetApplication().GetWindow(windowName);
                return window;
            }
            catch (Exception exception)
            {
                LogWriter.GetLogger().Error("Error finding window {windowName}", windowName);
                throw exception;
            }
        }
    }
}
