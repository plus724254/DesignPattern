using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Model
{
    public abstract class Subscriber<T> : IObserver<T>
    {
        protected IDisposable unSubscriber;
        public virtual void Subscribe(IObservable<T> observable)
        {
            if(observable != null)
            {
                unSubscriber = observable.Subscribe(this);
            }
        }
        public abstract void OnCompleted();

        public virtual void OnError(Exception error)
        {
            Console.WriteLine($"Error:{error.Message}");
        }
        public abstract void OnNext(T value);

        public virtual void UnSubscribe()
        {
            unSubscriber.Dispose();
        }
    }
}
