using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 40);
            double area, perimetro, diagonal;
            Console.WriteLine("Informe a altura do triângulo");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largura do triângulo");
            double largura = double.Parse(Console.ReadLine());
            area = largura * altura;
            perimetro = (largura * 2) + (altura * 2);
            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
            Console.WriteLine(sep);
            Console.WriteLine($"Área do retâgulo:{area.ToString("F2")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Perímetro do retângulo: {perimetro.ToString("F2")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Diagonal do retângulo: {diagonal.ToString("F2")}");
            Console.WriteLine(sep);

        }

        public static double CalculaArea(double area)
        {
            return area;
        }

        public static double CalculaPerimetro(double perimetro)
        {
            return perimetro;
        }

        public static double CalculaDiagonal(double diagonal)
        {
            return diagonal;
        }
    }
}
