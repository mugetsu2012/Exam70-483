using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_9
{
    class Program
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }

        static void Main(string[] args)
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith((prevTask) => WorldTask());
            Task.WaitAll(task);
            Console.WriteLine("Process finished. Press any key to end");
            Console.ReadKey();
        }
    }
}
