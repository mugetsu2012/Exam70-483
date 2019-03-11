using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solo se permite que posea 5 elementos
           //BlockingCollection<int> data = new BlockingCollection<int>(new ConcurrentStack<int>(), 5);

           // Task.Run(() =>
           // {
           //     //Intentamos agregar 10 elementos, se bloquea a los 5
           //     for (int i = 0; i < 11; i++)
           //     {
           //         data.Add(i);
           //         Console.WriteLine("Data {0} added sucessfully", i);
           //     }

           //     //Indicamos que ya no agregaremos mas
           //     data.CompleteAdding();
           // });

           // Console.ReadKey();
           // Console.WriteLine("Reading collection");

           // Task.Run(() =>
           // {
           //     while (!data.IsCompleted)
           //     {
           //         try
           //         {
           //             int v = data.Take();
           //             Console.WriteLine("Data {0} taken sucessfully.", v);
           //         }
           //         catch (InvalidOperationException e)
           //         {

           //         }
           //     }
           // });

           // Console.ReadKey();

            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();
            if (ages.TryAdd("Rob", 21))
            {
                Console.WriteLine("Rob agregado correctamente");
            }
            Console.WriteLine("Rob's age: {0}", ages["Rob"]);

            if (ages.TryUpdate("Rob", 22, 21))
            {
                Console.WriteLine("Rob's new age: {0}", ages["Rob"]);
            }

            ages.AddOrUpdate("Rob", 1, (name, age) => age = age + 1);
            Console.WriteLine("Rob's new age: {0}", ages["Rob"]);
            Thread.Sleep(-1);
        }
    }
}
