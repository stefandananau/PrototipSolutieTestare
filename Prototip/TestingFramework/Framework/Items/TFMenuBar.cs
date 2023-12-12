using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace TestingFramework.Framework.Items
{
    public class TFMenuBar : TFItem<MenuBar>
    {
        public TFMenuBar(SearchCriteria searchCriteria, Window window, string friendlyName)
            : base(searchCriteria, window, friendlyName)
        {
        }

        public TFMenu FindMenuItem(string path)
        {
            return new TFMenu(base.GetItem().TopLevelMenu.Find(path), path);
        }
    }
}
