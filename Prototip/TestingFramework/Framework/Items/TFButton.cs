using System.Collections.Generic;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Items
{
    public class TFButton : TFItem<Button>
    {
        public TFButton(SearchCriteria searchCriteria, Window window, string friendlyName)
            : base(searchCriteria, window, friendlyName)
        {
        }

        public TFButton(UIItem uiItem)
            : base(uiItem)
        {
        }

        public static List<TFButton> GetAllButtons(Window scope)
        {
            IUIItem[] array = scope.GetMultiple(SearchCriteria.ByClassName("Button").AndControlType(ControlType.Button));
            List<TFButton> list = new List<TFButton>();
            foreach (IUIItem item in array)
            {
                list.Add(new TFButton((Button)item));
            }
            return list;
        }

        public new string GetName()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button name returned", friendlyName);
            return base.GetName();
        }

        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button clicked", friendlyName);
            base.Click();
        }
    }
}
