using System;

namespace AreaCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float lado1;
            float lado2;

            Console.WriteLine("Digite el Lado 1: ");
            lado1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Lado 2: ");
            lado2 = float.Parse(Console.ReadLine());

            Cuadrilatero c1 = new Cuadrilatero(lado1,lado2); // instancia de la clase

            if (lado1 == lado2)
            {
                c1 = new Cuadrilatero(lado1);
            }
            else
            {
                c1 = new Cuadrilatero(lado1, lado2); 
            }

            //salida
            Console.WriteLine("Primer Dato Dado es: " + lado1);
            Console.WriteLine("Segundo Dato Dado es: " + lado2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            

            Console.WriteLine("El Perimetro es: " + c1.getPerimetro());
            Console.WriteLine("El Area es: " + c1.getArea());
            Console.WriteLine("-----------------------------------");
            //cambio 3 en Mac
            

        }
    }
}
