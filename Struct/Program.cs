using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        public struct Livro
        {
            public string titulo;
            public string autor;
            public int isbn;
        }

        static void Main(string[] args)
        {
            Livro livro1 = new Livro();

            livro1.autor = "Andre Homes";
            livro1.titulo = "A cabana";
            livro1.isbn = 569898;


        }
    }
}
