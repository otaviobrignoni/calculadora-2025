namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static string[] operationLog = new string[100];
        static int logCounter = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                int userChoice = OptionMenu();
                string result;
                switch (userChoice)
                {                    
                    case 1:                        
                        result = CalculateAdition();
                        ShowResult(result);
                        break;
                    case 2:
                        result = CalculateSubtraction();
                        ShowResult(result);
                        break;
                    case 3:
                        result = CalculateMultiplication();
                        ShowResult(result);
                        break;
                    case 4:
                        result = CalculateDivision();
                        ShowResult(result);
                        break;
                    case 5:
                        CalculateTimesTable();
                        break;
                    case 6:
                        ShowOperationLog();

                        break;
                    case 7:
                        Console.WriteLine("Até a próxima!");
                        return;
                }
                char optionContinue = YesNoQuestion();
                if (optionContinue != 'S')
                    return;
            }
        }

        static int OptionMenu()
        {
            int number;
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        Calculadora 2025        ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico");
            Console.WriteLine("7 - Sair");
            Console.Write("\nEscolha uma opção -> ");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 && number > 7)
                Console.Write("Opção invalida tente novamente ->");
            return number;
        }

        static decimal GetUserNumber(string type)
        {
            Console.Write($"Digite {type} número -> ");
            decimal userNumber = Convert.ToDecimal(Console.ReadLine());
            return userNumber;
        }

        static string CalculateAdition()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             Adição             ");
            Console.WriteLine("--------------------------------");
            decimal firstNumber = GetUserNumber("o primeiro");
            decimal secondNumber = GetUserNumber("o segundo");
            decimal result = firstNumber + secondNumber;
            string resultString = $"{firstNumber} + {secondNumber} = {result.ToString("F2")}";
            operationLog[logCounter] = resultString;
            logCounter++;
            return resultString;
        }

        static string CalculateSubtraction()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("           Subtração            ");
            Console.WriteLine("--------------------------------");
            decimal firstNumber = GetUserNumber("o primeiro");
            decimal secondNumber = GetUserNumber("o segundo");
            decimal result = firstNumber - secondNumber;
            string resultString = $"{firstNumber} - {secondNumber} = {result.ToString("F2")}";
            operationLog[logCounter] = resultString;
            logCounter++;
            return resultString;
        }

        static string CalculateMultiplication()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("          Multiplicação         ");
            Console.WriteLine("--------------------------------");
            decimal firstNumber = GetUserNumber("o primeiro");
            decimal secondNumber = GetUserNumber("o segundo");
            decimal result = firstNumber * secondNumber;
            string resultString = $"{firstNumber} × {secondNumber} = {result.ToString("F2")}";
            operationLog[logCounter] = resultString;
            logCounter++;
            return resultString;
        }

        static string CalculateDivision()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("            Divisão             ");
            Console.WriteLine("--------------------------------");
            decimal firstNumber = GetUserNumber("o primeiro");
            decimal secondNumber = GetUserNumber("o segundo");
            while (secondNumber == 0)
            {
                Console.Write("Não é possível dividir por 0\nDigite o segundo número novamente -> ");
                secondNumber = Convert.ToDecimal(Console.ReadLine());
            }
            decimal result = firstNumber / secondNumber;
            string resultString = $"{firstNumber} ÷ {secondNumber} = {result.ToString("F2")}";
            operationLog[logCounter] = resultString;
            logCounter++;
            return resultString;
        }

        static void CalculateTimesTable()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             Tabuada            ");
            Console.WriteLine("--------------------------------");

            int userNumber = Convert.ToInt32(GetUserNumber("qualquer"));
            int timesTable = userNumber;
            Console.WriteLine("--------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} × {i} = {timesTable}");
                timesTable += userNumber;
            }
        }

        static void ShowOperationLog()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("     Histórico de Operações     ");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < operationLog.Length; i++)
            {
                if (operationLog[i] != null)
                    Console.WriteLine($"{i+1}: {operationLog[i]}");
            }
            Console.Write("Pressione enter para continuar...");
            Console.ReadLine();
        }

        static void ShowResult(string result)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Resultado: {result}");
            Console.WriteLine("--------------------------------");
        }

        static char YesNoQuestion()
        {
            Console.Write("\nDeseja voltar para o menu? (S/N) -> ");
            string userInput = Console.ReadLine()!.ToUpper();
            while (userInput != "S" && userInput != "N")
            {
                Console.Write("Opção inválida, tente novamente -> ");
                userInput = Console.ReadLine()!.ToUpper();
            }
            return userInput[0];
        }

        
    }
}
