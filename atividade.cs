internal class Program
    {
        private static void Main(string[] args)
        {
            //Declaração de variaveis
            const string nomeConsole = "Calculadora poligono";
            int lados;
            double area = 0, medida;


            //Nome do aplicativo de console
            Console.Title = nomeConsole;

            //Entrada de dados
            Console.Write("Digite o número de lados do poligono: ");
            Console.ForegroundColor = ConsoleColor.Red;
            lados = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Digite a medida do lado do poligono: ");
            Console.ForegroundColor = ConsoleColor.Red;
            medida = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (lados == 3)
            {
                //Calculo da área de um triangulo equilatero
                area = (Math.Pow(medida, 2) * Math.Sqrt(3)) / 4;
                Console.WriteLine("O poligono é um trinângulo");
            }
            else if (lados == 4)
            {
                //Calculo da área de um quadrado
                area = medida * medida;
                Console.WriteLine("O poligono é um quadrado");
            }
            else if (lados == 5)
            {
                //Calculo da área de um pentagono
                area = CalcularAreaPentagono(medida);
                Console.WriteLine("O poligono é um pentagono");
            }

            //Saída de dados
            Console.WriteLine($"O poligono tem area igual a {area:N}");

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
