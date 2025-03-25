using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante_X
{
    public static class GerarDiamante
    {
        public static void ApresentarDiamante(int tamanho)
        {
            int meio = tamanho / 2;

            for (int i = 0; i <= meio; i++)
            {
                string linha = $"{new string(' ', meio - i)}{new string('x', 2 * i + 1)}";
                Console.WriteLine(linha);
            }

            for (int i = meio - 1; i >= 0; i--)
            {
                string linha = $"{new string(' ', meio - i)}{new string('x', 2 * i + 1)}";
                Console.WriteLine(linha);
            }
        }
    }
}
