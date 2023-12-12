using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
namespace TestingFramework.Framework.Items
{
    public class TFMenu : TFItem<Menu>
    {
        public TFMenu(SearchCriteria searchCriteria, Window window, string friendlyName)
            : base(searchCriteria, window, friendlyName)
        {
        }

        public TFMenu(Menu menu, string friendlyName)
        {
            uiItem = menu;
            this.friendlyName = friendlyName;
        }

        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} menu item clicked", friendlyName);
            base.Click();
        }
    }
}
