using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatriz
{
    internal class MatrizDeInteiros
    {
        int[,] matriz;

        public MatrizDeInteiros(int linha, int coluna)
        {
            matriz = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                    matriz[i, j] = i;
            }
        }

        public string Inserir(int linha, int coluna, int valor)
        {
            if (linha > matriz.GetLength(0) || coluna > matriz.GetLength(1))
            {
                return "A linha é maior que a coluna";
            }
            else
            {
                matriz[linha, coluna] = valor;
                return " O valor foi inserido na matriz";
            }
        }

        public string Equadrada()
        {
            bool quadrada;

            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                quadrada = true;

            }
            else
            {
                quadrada = false;
            }
            return quadrada.ToString();
        }

        public int Total()
        {
            int total = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    total += matriz[i, j];
                }
            }
            return total;
        }

    }
}
