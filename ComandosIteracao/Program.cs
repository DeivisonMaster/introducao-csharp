using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandosIteracao
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while C#
            int a = 0;
            do
            {
                Console.WriteLine("Indice: " + a.ToString() + " Do While");
                a++;
            } while (a < 10);



            // while C#
            int b = 0;
            while (b < 10)
            {
                Console.WriteLine("Indice: " + b.ToString() + " While");
                b++;
            }

            



            // for C#
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Indice: " + i + " - For em C#");
            }

            Console.ReadKey();
        }
    }
}
