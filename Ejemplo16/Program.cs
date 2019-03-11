using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo16
{
    class Program
    {
        static void DoWork(object state)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }

            Console.ReadKey();
        }
    }
}
