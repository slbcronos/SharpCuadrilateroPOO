using System;
namespace AreaCuadrado
{
    public class Cuadrilatero
    {
        //Atributos
        private float lado1;
        private float lado2;

        //Genera constructor
        public Cuadrilatero(float lado1, float lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        //caonstructor de un solo lado
        public Cuadrilatero(float lado1)
        {
            this.lado1 = this.lado2 = lado1;
        }

        //Metodos

        public float getPerimetro()
        {
            float primetro = 2 * (lado1 + lado2);
            return primetro;
        }

        public float getArea()
        {
            float area = lado1 * lado2;
            return area;
        }


    }
}
