using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_6
{
    class Program
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
        }


        static void Main(string[] args)
        {
            Task newTask = new Task(() => DoWork());
            newTask.Start();
            newTask.Wait();
        }
    }
}
