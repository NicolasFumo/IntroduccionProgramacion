using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioCafetera
{
    public class Cafetera
    {
        public int Leche;
        public int Agua;
        public int Cafe;
        public int MinContenedor;
        public int MaxContenedor;

        public void Encender()
        {
            Console.Write("Ingrese cantidad Leche: ");
            Leche = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Cafe: ");
            Cafe = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Agua: ");
            Agua = int.Parse(Console.ReadLine());
        }
        public void MostrarContenedores()
        {
            Console.WriteLine();
            Console.WriteLine($"Queda: Leche:{Leche}, Cafe:{Cafe} y Agua:{Agua}");
            Console.WriteLine();
        }
        public void PrepararSuave()
        {
            if(Agua > 130 && Cafe > 70)
            {
                //Agua = Agua - 130;
                Agua -= 130;
                Cafe -= 70;

                Console.WriteLine();
                Console.WriteLine("Se preparó un cafe SUAVE");
                Console.WriteLine();

                MostrarContenedores();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No se puede preparar el café por falta de líquido");
                Console.WriteLine();
            }
            
            
        }
        public void PrepararFuerte()
        {
            if (Agua > 90 && Cafe > 110)
            {
                //Agua = Agua - 130;
                Agua -= 90;
                Cafe -= 110;

                Console.WriteLine();
                Console.WriteLine("Se preparó un cafe FUERTE");
                Console.WriteLine();

                MostrarContenedores();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No se puede preparar el café por falta de líquido");
                Console.WriteLine();
            }
        }
        public void PrepararConLeche()
        {
            if (Agua > 50 && Cafe > 80 && Leche > 70)
            {
                //Agua = Agua - 130;
                Agua -= 50;
                Cafe -= 80;
                Leche -= 70;

                Console.WriteLine();
                Console.WriteLine("Se preparó un cafe CON LECHE");
                Console.WriteLine();

                MostrarContenedores();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No se puede preparar el café por falta de líquido");
                Console.WriteLine();
            }
        }

        public void RellenarLeche()
        {
            Console.Write("Ingrese cantidad de leche: ");
            int cantidad = int.Parse(Console.ReadLine());

            if(Leche + cantidad > 1000)
            {
                Leche = 1000;
            }
            else
            {
                Leche += cantidad;
            }

            MostrarContenedores();
        }
        public void RellenarCafe()
        {
            Console.Write("Ingrese cantidad de cafe: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (Cafe + cantidad > 1000)
            {
                Cafe = 1000;
            }
            else
            {
                Cafe += cantidad;
            }

            MostrarContenedores();
        }
        public void RellenarAgua()
        {
            Console.Write("Ingrese cantidad de agua: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (Agua + cantidad > 1000)
            {
                Agua = 1000;
            }
            else
            {
                Agua += cantidad;
            }

            MostrarContenedores();
        }

    }
}
