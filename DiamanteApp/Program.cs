using System.Globalization;

namespace DiamanteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante;
     

            Console.WriteLine("Digite um número para ver o desenho de diamentes: ");
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            int quantidadeBranco = (tamanhoDiamante - 1) / 2;
            int quantidadeX = 1;

            for (int i = 0; i < tamanhoDiamante / 2; i++)
            {
                for (int j = 0; j < quantidadeBranco; j++)
                {
                    Console.Write(" ");
                }
                quantidadeBranco--;
                for (int k = 0; k < quantidadeX; k++)
                {
                    Console.Write("X");
                }
                quantidadeX += 2;
                Console.WriteLine();
            }

            for (int i = 0; i < tamanhoDiamante; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();

            quantidadeBranco = 1;
            quantidadeX -= 2;

            for (int i = 0; i < tamanhoDiamante / 2; i++)
            {
                for (int j = 0; j < quantidadeBranco; j++)
                {
                    Console.Write(" ");
                }
                quantidadeBranco++;
                for (int k = 0; k < quantidadeX; k++)
                {
                    Console.Write("X");
                }
                quantidadeX -= 2;
                Console.WriteLine();
            }
        }
    }
}