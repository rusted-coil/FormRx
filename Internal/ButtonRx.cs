using System;
using System.Windows.Forms;
using System.Reactive.Subjects;

namespace Rcsrm.FormRx.Internal
{
    internal class ButtonRx : IButton
    {
        Subject<Unit> m_Clicked = new Subject<Unit>();
        public IObservable<Unit> Clicked => m_Clicked;

        public ButtonRx(Button button)
        {
            button.Click += new EventHandler(this.OnClick);
        }

        void OnClick(object sender, EventArgs e)
        {
            m_Clicked.OnNext(default);
        }
    }
}
