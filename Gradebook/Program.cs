﻿using System;
using System.Collections.Generic;

namespace Gradebook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("class grades");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStat();

            Console.WriteLine($"the mean is {stats.average}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");

        }
    }
}
