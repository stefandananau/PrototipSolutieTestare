using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Items
{
    public class TFItem<T> where T : UIItem
    {
        protected T uiItem;
        protected SearchCriteria locator;
        protected Window window;
        protected string friendlyName;

        protected TFItem()
        {
        }

        protected TFItem(SearchCriteria searchCriteria, Window window, string friendlyName)
        {
            locator = searchCriteria;
            this.friendlyName = friendlyName;
            this.window = window;
        }

        protected TFItem(UIItem uiItem)
        {
            this.uiItem = (T)uiItem;
        }

        protected T GetItem()
        {
            if (locator == null)
            {
                return uiItem;
            }

            try
            {
                uiItem = window.Get<T>(locator);
            }
            catch (Exception ex)
            {
                LogWriter.GetLogger().Error("Failed to capture object {friendlyName}", friendlyName);
                LogWriter.GetLogger().Debug(ex);
            }
            return uiItem;
        }

        protected string GetName()
        {
            return GetItem().Name;
        }

        protected void Click()
        {
            GetItem().Click();
        }

        public bool IsVisible()
        {
            return GetItem().Visible;
        }
    }
}
