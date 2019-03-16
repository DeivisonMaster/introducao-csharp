using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // array de unica dimensão
                int[] a1 = new int[3];

                a1[0] = 12;
                a1[1] = 3;
                a1[2] = 31;
                //a1[3] = 4;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array fora do indice" + e);
                Console.ReadKey();
            }


            int[] a2 = new int[] {10,55,31,533,00};

            string[] a3 = {"brazil", "usa", "china"};

            int tamanhoArray = a3.Length;

            // array multidimensional
            int[,] ma1 = new int[2, 3];


            ICollection lista1 = new ArrayList();
            ICollection lista2 = new List<Object>();

            IList lista3 = new ArrayList();
            IList lista4 = new List<Object>();


            Console.WriteLine(tamanhoArray);
            Console.ReadKey();
        }
    }
}
