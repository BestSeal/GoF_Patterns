namespace Observer
{
    public interface IObservable
    {
        void Register(IObserver o);
        void Remove(IObserver o);
        void Notify();
    }
}