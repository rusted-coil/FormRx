using System.Reactive;
using System.Reactive.Subjects;

namespace FormRx.Button.Internal
{
    internal sealed class ButtonEx : IButton
    {
        Subject<Unit> m_Clicked = new Subject<Unit>();
        public IObservable<Unit> Clicked => m_Clicked;

        public ButtonEx(System.Windows.Forms.Button button)
        {
            button.Click += new EventHandler(OnClick);
        }

        public ButtonEx(System.Windows.Forms.ToolStripMenuItem menuItem)
        { 
            menuItem.Click += new EventHandler(OnClick);
        }

        void OnClick(object? sender, EventArgs e) => m_Clicked.OnNext(default);
    }
}
