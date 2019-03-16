using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Object objeto1;

            int a1 = 12;
            int a2 = 4;

            object o = a1;

            //Console.WriteLine(b.GetType());
            //Console.ReadKey();

            int c = (int) o;

            // Conversão explicita com acesso a métodos e atributos
            string d = ((int) o).ToString();

            Type tipo = d.GetType();

            Console.WriteLine(tipo);
            Console.ReadKey();
        }
    }
}
