using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Model
{
    public class Publisher<T> : IObservable<T>
    {
        private List<IObserver<T>> _observers;
        public Publisher()
        {
            _observers = new List<IObserver<T>>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observers.Add(observer);
            return new UnSubscribe(_observers, observer);
        }

        public void Notification(T value)
        {
            _observers.ForEach(x => x.OnNext(value));
        }

        public void EndSpread()
        {
            while(_observers.Count > 0)
            {
                _observers[0].OnCompleted();
            }

            _observers.Clear();
        }

        private class UnSubscribe : IDisposable
        {
            private readonly List<IObserver<T>> _observers;
            private readonly IObserver<T> _observer;
            public UnSubscribe(List<IObserver<T>> observers, IObserver<T> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if(_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}
