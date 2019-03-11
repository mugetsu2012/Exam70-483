using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_2
{
    class Program
    {
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            //Declaramos un arreglo de 100 numeros complejos
            List<NumeroComplejo> numerosComplejos = new List<NumeroComplejo>();

            //Procedemos a crear 100 elementos con numeros enteros aleatorios
            for (int i = 0; i < 10000; i++)
            {
                numerosComplejos.Add(new NumeroComplejo()
                {
                    PrimerElemento = GetNumeroEnteroRandom(),
                    SegundoElemento = GetNumeroEnteroRandom()
                });
            }

            //Con nuestros 100 randoms, procedemos a realizar las pruebas
            
           

            var sw = Stopwatch.StartNew();
            Parallel.ForEach(numerosComplejos, numeroComplejo => { numeroComplejo.CalcularMcd(); });

            sw.Stop();
            Console.WriteLine("El proceso con Parallel dura: " + sw.ElapsedMilliseconds);

            var sw2 = Stopwatch.StartNew();
            foreach (NumeroComplejo numerosComplejo in numerosComplejos)
            {
                numerosComplejo.CalcularMcd();
            }
            sw2.Stop();
            Console.WriteLine("El proceso con normal dura: " + sw2.ElapsedMilliseconds);
            Console.ReadKey();
        }

        static int GetNumeroEnteroRandom()
        {
            return getrandom.Next(1, 10000);
        }
    }

    

    public class NumeroComplejo
    {
        public int PrimerElemento { get; set; }

        public int SegundoElemento { get; set; }

        private int Gcd(int a, int b)
        {

            // Everything divides 0  
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            // base case 
            if (a == b)
                return a;

            // a is greater 
            if (a > b)
                return Gcd(a - b, b);

            return Gcd(a, b - a);
        }

        public int CalcularMcd()
        {
            return Gcd(PrimerElemento, SegundoElemento);
        }

    }

    
}

