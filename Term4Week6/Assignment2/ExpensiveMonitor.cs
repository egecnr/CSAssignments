﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff very nicely...");
        }
    }
}