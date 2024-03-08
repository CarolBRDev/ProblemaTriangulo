using System;

namespace ProblemaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC; //lados dos triangulos
            Console.WriteLine("Informe os lados do triangulo X (um por vez: ")
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe os lados do triangulo Y: ")
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());


            double areaX = CalculoAreaTriangulo(xA, xB, xC);

            double areaY = CalculoAreaTriangulo(yA, yB, yC);

            Console.WriteLine($"Valor área X: {areaX.ToString("F2")}");
            Console.WriteLine($"Valor área y: {areaY.ToString("F2")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Area de X é maior");
            }
            else
            {
                Console.WriteLine("Area de Y é maior");
            }

        }

        public static double CalculoAreaTriangulo(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area
        }
    }
}
