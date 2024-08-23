using System.Reactive;

namespace FormRx.Button
{
    public interface IButton
    {
        /// <summary>
        /// クリックされた時にOnNextが通知されるストリームを取得します。
        /// </summary>
        IObservable<Unit> Clicked { get; }
    }
}
