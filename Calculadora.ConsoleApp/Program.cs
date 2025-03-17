namespace Calculadora.ConsoleApp;

internal class Program
{
    
    static void Main(string[] args)
    {
        while (true)
        {
            int userChoice = OptionMenu();
            string result;

            switch (userChoice)
            {
                case 1:
                    result = Calculator.Adition(GetUserNumber("o primeiro"), GetUserNumber("o segundo"));
                    ShowResult(result);
                    break;
                case 2:
                    result = Calculator.Subtraction(GetUserNumber("o primeiro"), GetUserNumber("o segundo"));
                    ShowResult(result);
                    break;
                case 3:
                    result = Calculator.Multiplication(GetUserNumber("o primeiro"), GetUserNumber("o segundo"));
                    ShowResult(result);
                    break;
                case 4:
                    result = Calculator.Division(GetUserNumber("o primeiro"), GetUserNumber("o segundo"));
                    ShowResult(result);
                    break;
                case 5:
                    string[] timesTableResult = Calculator.TimesTable(GetUserNumber("um"));
                    ShowTimesTable(timesTableResult);
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

    static void ShowTimesTable(string[] timesTable)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("             Tabuada            ");
        Console.WriteLine("--------------------------------");       
        for (int i = 0; i <= 9; i++) 
        {
            Console.WriteLine(timesTable[i]);
        }
    }

    static void ShowOperationLog()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("     Histórico de Operações     ");
        Console.WriteLine("--------------------------------");

        for (int i = 0; i < Calculator.GetOperationLog().Length; i++)
        {
            if (Calculator.GetOperationLog()[i] != null)
                Console.WriteLine($"{i+1}: {Calculator.GetOperationLog()[i]}");
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
