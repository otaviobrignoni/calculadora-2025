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
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção -> ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                    break;

                Console.Write("Digite o primeiro número -> ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número -> ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                if (opcao == "1")
                    resultado = primeiroNumero + segundoNumero;

                else if (opcao == "2")
                    resultado = primeiroNumero - segundoNumero;

                else if (opcao == "3")
                    resultado = primeiroNumero * segundoNumero;

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write("Não é possível dividir por 0\nDigite o segundo número novamente -> ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                }
                    
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("--------------------------------");
                Console.Write("Deseja continuar? (S/N) -> ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }           
        }
    }
}
