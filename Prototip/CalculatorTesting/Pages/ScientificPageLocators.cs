using TestingFramework.Framework.Forms;
using TestingFramework.Framework.Items;
using TestStack.White.UIItems.Finders;

namespace Testing.Pages
{
    public partial class ScientificPage : TFBaseForm
    {
        public ScientificPage(string windowName):base(windowName) { } 
        protected TFButton SquareResultButton => new TFButton(SearchCriteria.ByAutomationId("111"), window, "Square result");
    }
}
