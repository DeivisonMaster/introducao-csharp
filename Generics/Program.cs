using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            IList lista0 = new ArrayList();


            ArrayList lista1 = new ArrayList();
            lista1.Add(10);
            lista1.Add("ok");


            // GENERICS
            List<int> lista2 = new List<int>();
            lista2.Add(12);


            IList lista3 = new ArrayList();
            lista3.Add(3312);
            lista3.Add("ok");
        }
    }
}
