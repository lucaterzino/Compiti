using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompitiVacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;

            //"a" equivale al massimo valore che si può ottenere
            Console.WriteLine(a);

            //se sommato 1 ad "a" si ottiene il minimo valore che può ottenere dato che non si può andare oltre un determinato valore
            if (a < int.MaxValue)
            {
                Console.WriteLine(a + 1);
            }

            //
            int b = 128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));

            Console.WriteLine("Inserisci un numero");
            int value = Convert.ToInt32(Console.ReadLine());
            int somma = value;
            value = value - 1; //not
            //value = value +1
            somma = somma + value;
            Console.WriteLine($"il numero negativo è {value} e la somma con il numero inserito è {somma}");
            .

        }
    }
}
