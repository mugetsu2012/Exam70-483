using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_10
{
    class Program
    {
        public static void DoChild(object state)
        {
            Console.WriteLine("Child {0} starting", state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", state);
        }

        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent starts");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;
                    Task.Factory.StartNew((x) => DoChild(x), taskNo, TaskCreationOptions.DenyChildAttach);
                }
            });

            parent.Wait();

            Console.WriteLine("Parent finished. Press any key to end");
            Console.ReadKey();
        }
    }
}
