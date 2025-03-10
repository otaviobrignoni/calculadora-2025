using System.Numerics;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Calculadora 2025");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção -> ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                {
                    break;
                }

                Console.Write("Digite o primeiro número -> ");
                int primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número -> ");
                int segundoNumero = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;
                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("--------------------------------");
                Console.Write("Deseja continuar? (S/N) -> ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                if (opcaoContinuar != "S")
                {
                    break;
                }
            }           
        }
    }
}
