using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera19hs
{
    public class Cafetera
    {
        private int aguaPrivada;
        private int cafePrivada;
        private int lechePrivada;

        private int maximo = 1000;
        private int minimo = 0;
        public int Agua
        {
            get
            {
                return aguaPrivada;
            }
            set
            {
                if (value > minimo && value < maximo)
                {
                    aguaPrivada = value;
                }
                else
                {
                    Console.WriteLine("El valor del agua no es el correcto");
                    aguaPrivada = maximo;
                }
            }
        }
        public int Cafe
        {
            get
            {
                return cafePrivada;
            }
            set
            {
                if (value > minimo && value < maximo)
                {
                    cafePrivada = value;
                }
                else
                {
                    Console.WriteLine("El valor del cafe no es el correcto");
                    cafePrivada = maximo;
                }
            }
        }
        public int Leche
        {
            get
            {
                return lechePrivada;
            }
            set
            {
                if (value > minimo && value < maximo)
                {
                    lechePrivada = value;
                }
                else
                {
                    Console.WriteLine("El valor de la leche no es el correcto");
                    lechePrivada = maximo;
                }
            }
        }

        public void Encender()
        {
            Console.Write("Ingrese cantidad de agua: ");
            Agua = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de cafe: ");
            Cafe = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de leche: ");
            Leche = int.Parse(Console.ReadLine());
        }
        public void MostrarContenedores()
        {
            Console.WriteLine("");
            Console.WriteLine($"Agua: {Agua} cc.");
            Console.WriteLine($"Cafe: {Cafe} cc.");
            Console.WriteLine($"Leche: {Leche} cc.");
            Console.WriteLine("");
        }
        public void PrepararConLeche()
        {

        }
        public void PrepararFuerte()
        {

        }
        public void PrepararSuave()
        {

        }
        public void RellenarAgua()
        {

        }
        public void RellenarCafe()
        {

        }
        public void RellenarLeche()
        {

        }

    }
}
