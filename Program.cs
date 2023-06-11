using System;
using System.Globalization;
//Biblioteca usada para o codigo C#
namespace Course
{
    public class Triangulo //nomeando a classe
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Calcula a área do triângulo usando a fórmula de Heron
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0; // Calcula o semiperímetro
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Aplica a fórmula de Heron
            return area;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Lê as medidas dos triângulos X e Y
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");

            // Calcula as áreas de X e Y
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            // Exibe as áreas formatadas na tela
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Compara as áreas e exibe qual triângulo possui a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        // Método para ler as medidas de um triângulo e retornar um objeto Triangulo
        public static Triangulo LerTriangulo(string nomeTriangulo)
        { 
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return triangulo;
        }
    }
}
