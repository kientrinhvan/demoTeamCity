﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!");

            Tutorial tp = new Tutorial();
            tp.Name = "Continuous Integration";

            System.Console.WriteLine(tp.Name);
        }
    }
}
