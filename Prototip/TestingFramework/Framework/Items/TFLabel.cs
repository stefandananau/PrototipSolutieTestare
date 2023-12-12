using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Items
{
    public class TFLabel : TFItem<Label>
    {
        public TFLabel(SearchCriteria searchCriteria, Window window, string friendlyName)
            : base(searchCriteria, window, friendlyName)
        {
        }

        public new string GetName()
        {
            LogWriter.GetLogger().Debug("{friendlyName} label name returned", friendlyName);
            return base.GetName();
        }
    }
}
