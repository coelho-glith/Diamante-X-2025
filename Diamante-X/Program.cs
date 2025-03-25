using System.Reflection.Metadata.Ecma335;

namespace Diamante_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int tamanho = Menu.ExibirMenu();
                GerarDiamante.ApresentarDiamante(tamanho);

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
