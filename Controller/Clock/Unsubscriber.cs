using System;
using System.Collections.Generic;

namespace Controller.Clock
{
    internal class Unsubscriber<T> : IDisposable
    {
        private IObserver<Clock> observer;
        private List<IObserver<Clock>> observers;

        public Unsubscriber(List<IObserver<Clock>> observers, IObserver<Clock> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}