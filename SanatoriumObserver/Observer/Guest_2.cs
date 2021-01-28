using SanatoriumObserver.Timetable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Observer
{
    class Guest_2 : IObserver
    {
        public string Name { get; private set; }
        public Guest_2(string name)
        {
            Name = name;
        }
        public void Update(object o, string str)
        {

            if (o is TimeTable2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Доброго времени суток {Name}");
                Console.WriteLine(str);
                Console.WriteLine();
            }
        }
    }
}
