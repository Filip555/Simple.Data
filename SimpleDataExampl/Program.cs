using Simple.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SimpleDataExampl
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var timer = new Stopwatch();
                timer.Start();
                SimpleDataClass.GetTableBySD();
                timer.Stop();
                Console.WriteLine("Test with Simple.Data " + string.Format("{0:0.000}",
                    1000.0 * timer.ElapsedTicks / Stopwatch.Frequency) + " ms\n");

                var timer2 = new Stopwatch();
                timer2.Start();
                ORM.GetTableByORM();
                timer2.Stop();
                Console.WriteLine("Test with EF " + string.Format("{0:0.000}",
                    1000.0 * timer2.ElapsedTicks / Stopwatch.Frequency) + " ms\n");

            } while (Console.ReadKey(true).Key != ConsoleKey.Z);
        }
    }
}
