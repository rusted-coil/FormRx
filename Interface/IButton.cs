using System;
using System.Reactive;

namespace Rcsrm.FormRx
{
    public interface IButton
    {
        /// <summary>
        /// クリックされた時にOnNextが通知されるストリームを取得します。
        /// </summary>
        IObservable<Unit> Clicked { get; }
    }
}
