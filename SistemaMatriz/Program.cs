using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrizDeInteiros mat = new MatrizDeInteiros(3,2);
            Console.WriteLine(mat.Inserir(10,1,5));
           
            Console.WriteLine(mat.Equadrada());
            Console.WriteLine(mat.Total());

            Console.ReadKey();
        }
    }
}
