namespace Calculadora.ConsoleApp;

public static class Calculator
{
    static string[] operationLog = new string[100];
    static int logCounter = 0;

    public static string Adition(decimal firstNumber, decimal secondNumber)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("             Adição             ");
        Console.WriteLine("--------------------------------");
        decimal result = firstNumber + secondNumber;
        string resultString = $"{firstNumber} + {secondNumber} = {result.ToString("F2")}";
        operationLog[logCounter] = resultString;
        logCounter++;
        return resultString;
    }

    public static string Subtraction(decimal firstNumber, decimal secondNumber)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("           Subtração            ");
        Console.WriteLine("--------------------------------");
        decimal result = firstNumber - secondNumber;
        string resultString = $"{firstNumber} - {secondNumber} = {result.ToString("F2")}";
        operationLog[logCounter] = resultString;
        logCounter++;
        return resultString;
    }

    public static string Multiplication(decimal firstNumber, decimal secondNumber)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("          Multiplicação         ");
        Console.WriteLine("--------------------------------");
        decimal result = firstNumber * secondNumber;
        string resultString = $"{firstNumber} × {secondNumber} = {result.ToString("F2")}";
        operationLog[logCounter] = resultString;
        logCounter++;
        return resultString;
    }

    public static string Division(decimal firstNumber, decimal secondNumber)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("            Divisão             ");
        Console.WriteLine("--------------------------------");
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

    public static string[] TimesTable(decimal userNumber)
    {

        string[] timesTableLines = new string[10];
        decimal timesTable = userNumber;
        for (int i = 1; i <= 10; i++)
        {
            timesTableLines[i-1] = $"{userNumber} × {i} = {timesTable}";
            timesTable += userNumber;
        }
        operationLog[logCounter] = $"Você calculou a tabuada do {userNumber}";
        logCounter++;
        return timesTableLines;
    }

    public static string[] GetOperationLog() 
    {
        return operationLog;
    }

}
