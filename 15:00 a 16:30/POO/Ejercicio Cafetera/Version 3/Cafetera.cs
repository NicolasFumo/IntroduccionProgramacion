using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCafetera2
{
    public class Cafetera
    {
        public int Agua;
        public int Cafe;
        public int Leche;
        public int MinContenedor = 0;
        public int Maxcontenedor = 1000;

        public void PrepararSuave()
        {
            //Cafe = Cafe - 90;
            Cafe -= 70;
            Agua -= 130;

            Console.WriteLine("Se ha preparado un cafe SUAVE");

            MostrarContenido();
        }

        public void PrepararFuerte()
        {
            Cafe -= 110;
            Agua -= 90;

            Console.WriteLine("Se ha preparado un cafe FUERTE");

            MostrarContenido();
        }

        public void PrepararConLeche()
        {
            Cafe -= 80;
            Agua -= 50;
            Leche -= 70;

            Console.WriteLine("Se ha preparado un cafe CON LECHE");

            MostrarContenido();
        }

        public void RellenarAgua()
        {
            Console.WriteLine("Ingrese cantidad de agua a rellenar: ");
            int cantidad = int.Parse(Console.ReadLine());

            if(Agua + cantidad > Maxcontenedor)
            {
                Agua = Maxcontenedor;
            }
            else
            {
                Agua += cantidad;
            }

            Agua += cantidad;

            MostrarContenido();
        }

        public void RellenarCafe()
        {
            Console.WriteLine("Ingrese cantidad de cafe a rellenar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Cafe += cantidad;

            MostrarContenido();
        }

        public void RellenarLeche()
        {
            Console.WriteLine("Ingrese cantidad de leche a rellenar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Leche += cantidad;

            MostrarContenido();
        }

        public void Encender()
        {
            int cantidadAgua;
            int cantidadCafe;
            int cantidadLeche;

            do
            {
                Console.Write("Cantidad de agua: ");
                cantidadAgua = int.Parse(Console.ReadLine());

            } while (cantidadAgua < MinContenedor || cantidadAgua > Maxcontenedor);
            
            Agua = cantidadAgua;

            do
            {
                Console.Write("Cantidad de cafe: ");
                cantidadCafe = int.Parse(Console.ReadLine());

            } while (cantidadCafe < MinContenedor || cantidadCafe > Maxcontenedor);

            Cafe = cantidadCafe;

            do
            {
                Console.Write("Cantidad de leche: ");
                cantidadLeche = int.Parse(Console.ReadLine());

            } while (cantidadLeche < MinContenedor || cantidadLeche > Maxcontenedor);

            Leche = cantidadLeche;

        }

        public void MostrarContenido()
        {
            Console.WriteLine("");
            Console.WriteLine($"Quedan {Agua} de Agua");
            Console.WriteLine($"Quedan {Cafe} de Cafe");
            Console.WriteLine($"Quedan {Leche} de Leche");
            Console.WriteLine("");
        }
    }
}
