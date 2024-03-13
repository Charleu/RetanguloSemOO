using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, perimetro, diagonal;
            Console.WriteLine("Informe a altura do triângulo");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do triângulo");
            double largura = double.Parse(Console.ReadLine());

            area = largura * altura;
            perimetro = (largura * 2) + (altura * 2);
            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"A área do retâgulo:{area.ToString("F2")}\n");
            Console.WriteLine($"Perímetro do retângulo: {perimetro.ToString("F2")}\n");
            Console.WriteLine($"Diagonal do retângulo: {diagonal.ToString("F2")}");

        }
    }
}
