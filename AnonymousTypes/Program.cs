using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // tornando variavel do tipo numerica nula em C#
            int? i = null;
            string s = null;


            // Anonymous Type
            var valores = new[] {
                new { idade = 18, nome = "Luis" },
                new { idade = 22, nome = "Alberto" }
            };


            foreach (var valor in valores)
            {
                Console.WriteLine("Idade: " + valor.idade + " " + "Nome: " + valor.nome);
            }
            Console.ReadKey();
        }
    }
}
