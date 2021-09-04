using ObservablePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Concrete
{
    public class Subscriber : IObserver
    {
        private readonly Publisher _observableObject;

        public Subscriber(Publisher o)
        {
            _observableObject = o;
            _observableObject.RegisterObserver(this);
        }
        public void Update(ISubject subject)
        {
            if (subject == _observableObject)
            {
                Console.WriteLine($"[Warning] - The publisher changed your status to: {_observableObject.GetEdition()}");
            }
        }
    }
}
