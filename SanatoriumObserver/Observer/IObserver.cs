﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Observer
{
    interface IObserver
    {
        void Update(object o, string str); 
    }
}
