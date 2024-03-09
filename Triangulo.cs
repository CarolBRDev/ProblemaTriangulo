using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaTriangulo
{
    public class Triangulo
    {
        public double ladoA; //atributos
        public double ladoB;
        public double ladoC;


        public double CalculoArea() //método
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }
    }
}



