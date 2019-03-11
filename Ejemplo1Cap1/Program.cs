using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo1Cap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished process. Press any key to end");
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Tasn 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }
    }
}
