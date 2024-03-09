using System;

namespace ProblemaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            x = new Triangulo();
            Triangulo y = new Triangulo();


            Console.WriteLine("Informe os lados do triangulo X (um por vez: ");
            x.ladoA = double.Parse(Console.ReadLine());
            x.ladoB = double.Parse(Console.ReadLine());
            x.ladoC = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe os lados do triangulo Y: ");
            y.ladoA = double.Parse(Console.ReadLine());
            y.ladoB = double.Parse(Console.ReadLine());
            y.ladoC = double.Parse(Console.ReadLine());


            double areaX = x.CalculoArea(); //x - objeto; .CalculoArea - chama o metodo que ta descrito dentro da classe

            double areaY = y.CalculoArea();

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

    }





}
