using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread Starting");
                Thread.Sleep(1000);
                Console.WriteLine("Thread done");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join();
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
