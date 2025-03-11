using System.Numerics;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

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
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico");
                Console.WriteLine("S - Sair");

                Console.Write("\nEscolha uma opção -> ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                    break;
                else if (opcao == "5")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------------");

                    Console.Write("Digite um número -> ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    int resultadoTabuada = numeroTabuada;
                    Console.WriteLine("--------------------------------");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numeroTabuada} x {i} = {resultadoTabuada}");
                        resultadoTabuada += numeroTabuada;
                    }
                    Console.Write("\nDeseja continuar? (S/N) -> ");
                    string continuar = Console.ReadLine().ToUpper();
                    if (continuar != "S")
                        break;
                    else
                        continue;
                }
                else if (opcao == "6")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("--------------------------------");

                    for (int i = 0; i < historicoOperacoes.Length; i++)
                    {
                        if (historicoOperacoes[i] != null)
                            Console.WriteLine(historicoOperacoes[i]);
                    }
                    Console.WriteLine("\nPressione enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número -> ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número -> ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                    
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} × {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write("Não é possível dividir por 0\nDigite o segundo número novamente -> ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} ÷ {segundoNumero} = {resultado}";
                }
                contadorHistorico++;

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Resultado: {resultado.ToString("F2")}");
                Console.WriteLine("--------------------------------");
                Console.Write("\nDeseja continuar? (S/N) -> ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
