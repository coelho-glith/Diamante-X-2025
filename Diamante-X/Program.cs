using System.Reflection.Metadata.Ecma335;

namespace Diamante_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número impar: ");
            if (!int.TryParse(Console.ReadLine(), out int tamanho))
            {
                Console.WriteLine("Número Inteiro Invalido, Pressione novamente para continuar");
                Console.ReadLine();
            }
            
            if (tamanho % 2 == 0)
            {
                Console.WriteLine("Número informado não é ímpar. Pressione novamente para continuar");
                Console.ReadLine();
            }

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
