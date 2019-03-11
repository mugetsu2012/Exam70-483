using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_8
{
    class Program
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;
        }

        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => { return CalculateResult(); });
            
            Console.WriteLine(task.Result);
            Console.WriteLine("Finished process. Press any key to end");
            Console.ReadKey();
        }
    }
}
