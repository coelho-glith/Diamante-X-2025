using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Diamante_X
{
    public static class Menu
    {
        public static int ExibirMenu(int valor = 0)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva um número impar: ");
                if (!int.TryParse(Console.ReadLine(), out int tamanho))
                {
                    Console.WriteLine("Número Inteiro Invalido, Pressione novamente para continuar");
                    Console.ReadLine();
                    continue;
                }

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Número informado não é ímpar. Pressione novamente para continuar");
                    Console.ReadLine();
                    continue;
                }

                valor = tamanho;
                return valor;
            } while (true);
        }
    }
}
