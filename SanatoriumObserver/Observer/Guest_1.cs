﻿using SanatoriumObserver.Timetable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Observer
{
    class Guest_1 : IObserver
    {
        public string Name { get; private set; }
        public Guest_1(string name)
        {
            Name = name;
        }
        public void Update(object o, string str)
        {

            if (o is TimeTable1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Доброго времени суток {Name}");
                Console.WriteLine(str);
                Console.WriteLine();
            }
        }
    }
}
