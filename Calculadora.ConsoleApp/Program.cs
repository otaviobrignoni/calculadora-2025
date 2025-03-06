using System.Numerics;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora 2025");

            Console.Write("Digite o primeiro número -> ");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número -> ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            int resultado = primeiroNumero + segundoNumero;
            Console.WriteLine("Resultado: " + resultado);

            Console.ReadLine();
        }
    }
}
