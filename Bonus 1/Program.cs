using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            var source = Enumerable.Range(1, 10000);

            // Opt in to PLINQ with AsParallel.
            var evenNums = from num in source.AsParallel()
                where num % 2 == 0
                select num;
            Console.WriteLine("{0} even numbers out of {1} total",
                evenNums.Count(), source.Count());
            sw.Stop();
            Console.WriteLine("Finaliza el proceso en un total de : " + sw.ElapsedMilliseconds);

            Console.WriteLine("------------Second event-----------------------");

            var sw2 = Stopwatch.StartNew();
            var source2 = Enumerable.Range(1, 10000);

            // Opt in to PLINQ with AsParallel.
            var evenNums2 = from num in source2
                where num % 2 == 0
                select num;
            Console.WriteLine("{0} even numbers out of {1} total",
                evenNums2.Count(), source2.Count());
            sw2.Stop();
            Console.WriteLine("Finaliza el proceso en un total de : " + sw2.ElapsedMilliseconds);

            Console.WriteLine("------------Fin-----------------------");


            Console.ReadKey();


        }
    }
}
