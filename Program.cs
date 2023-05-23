using System;
using System.Globalization;

namespace Course
{

    public class Triangulo
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalcularArea()
        {

            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

    }

    public class Program
    {

        public static void Main(string[] args)
        {

            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");

            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        public static Triangulo LerTriangulo(string nomeTriangulo)
        { 

                Triangulo triangulo = new Triangulo();

                Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ";");
                triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                return triangulo;
        
          
        }
    }

}