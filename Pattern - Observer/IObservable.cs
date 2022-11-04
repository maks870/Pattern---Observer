using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Observer
{
    public interface IObservable
    {
        public void AddObserver(Observer obs);
        public void RemoveObserver(Observer obs);
        public void NotifyObservers();
    }
}
