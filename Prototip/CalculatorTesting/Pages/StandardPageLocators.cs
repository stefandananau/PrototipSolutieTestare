using System.Collections.Generic;
using System.Linq;
using TestingFramework.Framework.Forms;
using TestingFramework.Framework.Items;
using TestStack.White.UIItems.Finders;

namespace Testing.Pages
{
    public partial class StandardPage : TFBaseForm
    { 
        public StandardPage(string windowName):base(windowName) { }
        protected TFButton DecimalSeparatorButton => new TFButton(SearchCriteria.ByAutomationId("84"), window, "Decimal separator");
        protected TFButton AddButton => new TFButton(SearchCriteria.ByAutomationId("93"), window, "Add");
        protected TFButton EqualsButton => new TFButton(SearchCriteria.ByAutomationId("121"), window, "Equals");
        protected TFButton MemoryAddButton => new TFButton(SearchCriteria.ByAutomationId("125"), window, "Memory add");
        protected TFButton MemoryRecallButton => new TFButton(SearchCriteria.ByAutomationId("123"), window, "Memory recall");
        protected TFLabel ResultLabel => new TFLabel(SearchCriteria.ByAutomationId("150"), window, "Result");
        protected TFButton DigitButton(char digit) => new TFButton(SearchCriteria.ByAutomationId($"13{digit}"), window, $"Button {digit}");
    }
}
