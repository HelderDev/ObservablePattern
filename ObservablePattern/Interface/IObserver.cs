using System;
using System.Collections.Generic;
using System.Text;

namespace ObservablePattern.Interface
{
   public interface IObserver
    {
        void Update(ISubject subject);

    }
}
