using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_4
{
    class Program
    {

        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result = Parallel.For(0, items.Length, (int i, ParallelLoopState state) =>
            {
                if (i == 200)
                {
                    state.Break();
                }

                WorkOnItem(items[i]);
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: "+ result.LowestBreakIteration);

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
