﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week6
{
    public class CheapMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff very poorly...");
        }
    }
}
