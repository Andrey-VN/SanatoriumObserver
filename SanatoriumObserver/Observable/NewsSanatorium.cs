using SanatoriumObserver.Observer;
using SanatoriumObserver.Timetable;
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
        TimeTable1 timeTable1;
        TimeTable2 timeTable2;
        public NewsSanatorium()
        {
            observer = new List<IObserver>();
            timeTable1 = new TimeTable1();
            timeTable2 = new TimeTable2();
        }
        public void AddObserver(IObserver o)
        {
            observer.Add(o);
        }

        public void NotifyObservers()
        {
            string mess1 = timeTable1.RandomTimetable();
            string mess2 = timeTable2.RandomTimetable();
            if (observer!= null)
            {
                foreach (var i in observer)
                {
                    i.Update(timeTable1, mess1);
                    i.Update(timeTable2, mess2);
                }
                   
            }

        }

        public void RemoveObserver(IObserver o)
        {
            observer.Remove(o);
        }
    }
}
