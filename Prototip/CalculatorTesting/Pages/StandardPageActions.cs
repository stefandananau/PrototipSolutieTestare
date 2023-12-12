using Castle.Core.Internal;
using TestingFramework.Framework.Forms;

namespace Testing.Pages
{
    public partial class StandardPage : TFBaseForm
    {
        public void InputNumber(string numberAsString)
        {
            numberAsString.ForEach(character => DigitButton(character).Click());
        }

        public void AddNumber(string numberAsString)
        {
            AddButton.Click();
            InputNumber(numberAsString);
            EqualsButton.Click();
        }

        public void AddResultToMemory()
        {
            MemoryAddButton.Click();
        }

        public void AddFromMemory()
        {
            AddButton.Click();
            MemoryRecallButton.Click();
            EqualsButton.Click();
        }

        public string GetResult()
        {
            return ResultLabel.GetName();
        }
    }
}
