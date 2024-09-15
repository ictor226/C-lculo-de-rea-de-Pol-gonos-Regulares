using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declaração de variáveis
        const string nomeConsole = "Calculadora Polígono";
        int lados;
        double area = 0, medida;

        // Nome do aplicativo de console
        Console.Title = nomeConsole;

        // Entrada de dados
        Console.Write("Digite o número de lados do polígono: ");
        Console.ForegroundColor = ConsoleColor.Red;
        lados = int.Parse(Console.ReadLine());
        Console.ResetColor();
        Console.Write("Digite a medida do lado do polígono (em mm): ");
        Console.ForegroundColor = ConsoleColor.Red;
        medida = double.Parse(Console.ReadLine());
        Console.ResetColor();

        if (lados == 3)
        {
            // Cálculo da área de um triângulo equilátero
            area = (Math.Pow(medida, 2) * Math.Sqrt(3)) / 4;
            Console.WriteLine("O polígono é um triângulo.");
        }
        else if (lados == 4)
        {
            // Cálculo da área de um quadrado
            area = medida * medida;
            Console.WriteLine("O polígono é um quadrado.");
        }
        else if (lados == 5)
        {
            // Cálculo da área de um pentágono
            area = CalcularAreaPentagono(medida);
            Console.WriteLine("O polígono é um pentágono.");
        }
        else
        {
            Console.WriteLine("Número de lados não suportado.");
        }

        // Saída de dados
        if (lados == 3 || lados == 4 || lados == 5)
        {
            Console.WriteLine($"A área do polígono é {area:N2} mm².");
        }

        Console.ReadKey();
    }

    static double CalcularAreaPentagono(double lado)
    {
        // Constante para o valor de pi
        const double PI = Math.PI;

        // Calcular a área usando a fórmula
        double area = (5.0 / 4.0) * Math.Pow(lado, 2) / Math.Tan(PI / 5.0);

        return area;
    }
}

    }
