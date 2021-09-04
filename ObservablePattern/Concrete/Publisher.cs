using ObservablePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Concrete
{
    public class Publisher : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private bool _newEdition = false;
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void ChangeEdition() {

            if (_newEdition)
                _newEdition = false;
            else
                _newEdition = true;

            NotifyObservers();
        }

        public bool GetEdition() {
            return _newEdition;
        }
    }
}
