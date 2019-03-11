using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_2
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
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item => { WorkOnItem(item); });

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
