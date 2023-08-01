using System;

namespace ConversorTemperatura
{
    class Program
    {
        static double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static void ExibirMenu()
        {
            Console.WriteLine("Menu de Conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ExibirMenu();
                Console.Write("Digite o número da opção desejada: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = CelsiusParaFahrenheit(celsius);
                    Console.WriteLine($"{celsius}°C equivale a {fahrenheit:F2}°F\n");
                }
                else if (escolha == "2")
                {
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double celsius = FahrenheitParaCelsius(fahrenheit);
                    Console.WriteLine($"{fahrenheit}°F equivale a {celsius:F2}°C\n");
                }
                else if (escolha == "3")
                {
                    Console.WriteLine("Encerrando o programa. Até logo!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.\n");
                }
            }
        }
    }
}

