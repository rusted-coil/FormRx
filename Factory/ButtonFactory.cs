using System.Windows.Forms;

namespace Rcsrm.FormRx
{
    public static class ButtonFactory
    {
        public static IButton CreateButton(Button button)
        {
            return new Internal.ButtonRx(button);
        }
    }
}
