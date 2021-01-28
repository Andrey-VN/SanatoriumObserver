using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Observer
{
    class Guest_2 : IObserver
    {
        public void Update(object o)
        {
            Console.WriteLine((string)o);
        }
    }
}
