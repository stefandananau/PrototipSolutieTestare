using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Items
{
    public class TFPanel : TFItem<Panel>
    {
        public TFPanel(SearchCriteria searchCriteria, Window window, string friendlyName)
            : base(searchCriteria, window, friendlyName)
        {
        }
    }
}
