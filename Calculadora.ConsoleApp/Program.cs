using System.Numerics;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] operationLog = new string[100];
            int logCounter = 0;
            
            while (true)
            {
                string option = OptionMenu();

                if (option == "S")
                    break;
                else if (option == "5")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------------");

                    Console.Write("Digite um número -> ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    int timesTable = userNumber;
                    Console.WriteLine("--------------------------------");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{userNumber} x {i} = {timesTable}");
                        timesTable += userNumber;
                    }
                    Console.Write("\nDeseja continuar? (S/N) -> ");
                    string continueProgram = Console.ReadLine().ToUpper();
                    if (continueProgram != "S")
                        break;
                    else
                        continue;
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("--------------------------------");

                    for (int i = 0; i < operationLog.Length; i++)
                    {
                        if (operationLog[i] != null)
                            Console.WriteLine(operationLog[i]);
                    }
                    Console.WriteLine("\nPressione enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número -> ");
                decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número -> ");
                decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

                decimal result = 0;

                if (option == "1")
                {
                    result = firstNumber + secondNumber;
                    operationLog[logCounter] = $"{firstNumber} + {secondNumber} = {result}";
                }
                else if (option == "2")
                {
                    result = firstNumber - secondNumber;
                    operationLog[logCounter] = $"{firstNumber} - {secondNumber} = {result}";
                    
                }
                else if (option == "3")
                {
                    result = firstNumber * secondNumber;
                    operationLog[logCounter] = $"{firstNumber} × {secondNumber} = {result}";
                }
                else if (option == "4")
                {
                    while (secondNumber == 0)
                    {
                        Console.Write("Não é possível dividir por 0\nDigite o segundo número novamente -> ");
                        secondNumber = Convert.ToDecimal(Console.ReadLine());
                    }
                    result = firstNumber / secondNumber;
                    operationLog[logCounter] = $"{firstNumber} ÷ {secondNumber} = {result}";
                }
                logCounter++;

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Resultado: {result.ToString("F2")}");
                Console.WriteLine("--------------------------------");
                Console.Write("\nDeseja continuar? (S/N) -> ");
                string optionContinue = Console.ReadLine().ToUpper();
                if (optionContinue != "S")
                    break;
            }
        }
        
        static string OptionMenu()
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
            return Console.ReadLine().ToUpper();
        }
    }
}
