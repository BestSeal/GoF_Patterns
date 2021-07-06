using System.Collections.Generic;

namespace Observer
{
    public class Scheduler : IObservable
    {
        private readonly List<IObserver> _observers;

        public Scheduler()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver o)
        {
            _observers.Add(o);
        }

        public void Remove(IObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Receive(this);
            }
        }
    }
}