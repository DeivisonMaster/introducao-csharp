using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one";

            string s2 = "one ";
            s2 += ",two ";
            s2 += ",three ";



            StringBuilder builder = new StringBuilder();
            builder.Append("one");
            builder.Append("two");

            int indice = s2.IndexOf("w");

            string s2Atualizado = s2.Insert(4, "four");

            int tamanhoString = s2.Length;
            string s2Remocao = s2.Remove(4,1);
            string s2Replace = s2.Replace("three", "five");
            string[] s2Split = s2.Split('.');

            Console.WriteLine(s2Split.ToString());
            Console.ReadKey();

        }
    }
}
