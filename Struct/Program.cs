using System;
using System.Collections;
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

            Livro livro2 = new Livro();
            livro2.autor = "Marisa Monte";
            livro2.titulo = "O amor nunca morre";
            livro2.isbn = 123812;


            List<Livro> livros = new List<Livro>();
            livros.Add(livro1);
            livros.Add(livro2);

            foreach (Livro livro in livros)
            {
                Console.WriteLine("Autor: " + livro.autor);
                Console.WriteLine("Titulo: " + livro.titulo);
                Console.WriteLine("ISBN: " + livro.isbn);
                Console.WriteLine("************************");
            }

            Livro liv = livros.ElementAt<Livro>(1);
            Console.WriteLine("Autor: " + liv.autor);

            Console.ReadKey();
        }
    }
}
