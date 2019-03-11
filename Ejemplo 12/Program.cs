using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tickThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickThread.Abort();
            Console.WriteLine("Pess a key to exit");
            Console.ReadKey();
        }
    }
}
