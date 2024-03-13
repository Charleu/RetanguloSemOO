using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 40);
            Console.WriteLine("Informe a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            double area = CalculaArea(altura, largura);
            double perimetro = CalculaPerimetro(altura, largura);
            double diagonal = CalculaDiagonal(altura, largura);
            Console.WriteLine(sep);
            Console.WriteLine($"Área do retângulo: {area.ToString("F2")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Perímetro do retângulo: {perimetro.ToString("F2")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Diagonal do retângulo: {diagonal.ToString("F2")}");
            Console.WriteLine(sep);
        }

        public static double CalculaArea(double altura, double largura)
        {
            return altura * largura;
        }

        public static double CalculaPerimetro(double altura, double largura)
        {
            return 2 * (altura + largura);
        }

        public static double CalculaDiagonal(double altura, double largura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
