using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversoes
{
    class Program
    {
        enum Acessorio
        {
            SAPATO,
            CINTO,
            BOLSA,
            CARTEIRA,
            COLAR
        }

        enum Genero
        {
            HOMEM = 1,
            MULHER = 2
        }
        

        static void Main(string[] args)
        {
            // Enumerações
            string homem = Enum.GetName(typeof(Genero), 1);

            foreach (string nomes in Enum.GetNames(typeof(Acessorio)))
            {
                //Console.WriteLine(nomes);
                //Console.ReadKey();
            }

            // CONVERSÕES
            int item = (int) Acessorio.CARTEIRA;

            // conversão implicita
            int item1 = 12;
            long item2 = item1;

            // conversão explicita
            double item3 = 10.9;
            int item4 = (int) item3;
            int item5 = Convert.ToInt32(item3);

            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
