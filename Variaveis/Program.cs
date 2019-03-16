using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        // escopo de instancia
        int a;

        static void Main(string[] args)
        {
            // declaração com escopo local
            int a;

            // inicialização 
            a = 32;

            // TIPOS PRIMITIVOS C#

            // Numéricos
            sbyte tSbyte = -128; // -128 a 127
            Byte tbyte = 255; // 0 a 255
            short tShort = -32768; // -32.768 a 32.767
            int tInt = -2147483648; // -2174483648 a 2.147.483.647
            long tLong = -9223372036854775808; // -9223372036854775808
            ushort tUshort = 65535; // 0 a 65.535
            uint tUint = 4294967295; // 0 a 4.294.967.295
            ulong tUlong = 18446744073709551615;

            float tFloat = 10.88F;
            double tDouble = 90.9876;

            decimal dec = 10112.2M;

            // Caracteres
            char tChar = 'M';
            string tString = "Hello World";


            

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
