using SanatoriumObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Observable
{
    class NewsSanatorium : IObservableSanatorium
    {
        List<IObserver> observer;

        public NewsSanatorium()
        {
            observer = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observer.Add(o);
        }

        public void NotifyObservers()
        {
            if(observer!= null)
            {
                foreach (var i in observer)
                    i.Update("fff");
            }

        }

        public void RemoveObserver(IObserver o)
        {
            observer.Remove(o);
        }
    }
}
