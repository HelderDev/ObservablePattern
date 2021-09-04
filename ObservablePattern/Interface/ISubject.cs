using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
