using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_11
{
    class Program
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from thread");
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadHello);
            thread.Start();

            Thread hilo = new Thread(() =>
            {
                Console.WriteLine("Hola desde el thread inline");
                Thread.Sleep(1000);
            });

            hilo.Start();
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
