using SanatoriumObserver.Observable;
using SanatoriumObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsSanatorium observableSanatorium = new NewsSanatorium();
            observableSanatorium.AddObserver(new Guest_1());
            observableSanatorium.AddObserver(new Guest_1());

            observableSanatorium.NotifyObservers();

            Console.ReadKey();

        }
    }
}
