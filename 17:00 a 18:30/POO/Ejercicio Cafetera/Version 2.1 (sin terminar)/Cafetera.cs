using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioCafetera
{
    public class Cafetera
    {
        public Contenedor Leche = new Contenedor(1000, 0);
        public Contenedor Agua = new Contenedor(1000, 0);
        public Contenedor Cafe = new Contenedor(1000, 0);

        public void Encender()
        {
            Console.Write("Ingrese cantidad Leche: ");
            Leche.Contenido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Cafe: ");
            Cafe.Contenido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Agua: ");
            Agua.Contenido = int.Parse(Console.ReadLine());
        }
        public void MostrarContenedores()
        {
            Console.WriteLine();
            Leche.MostrarContenido("Leche");
            Agua.MostrarContenido("Agua");
            Cafe.MostrarContenido("Cafe");
            Console.WriteLine();
        }
        public void PrepararSuave()
        {
            //if(Agua > 130 && Cafe > 70)
            //{
            //    //Agua = Agua - 130;
            //    Agua -= 130;
            //    Cafe -= 70;

            //    Console.WriteLine();
            //    Console.WriteLine("Se preparó un cafe SUAVE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("No se puede preparar el café por falta de líquido");
            //    Console.WriteLine();
            //}
            
            
        }
        public void PrepararFuerte()
        {
            //if (Agua > 90 && Cafe > 110)
            //{
            //    //Agua = Agua - 130;
            //    Agua -= 90;
            //    Cafe -= 110;

            //    Console.WriteLine();
            //    Console.WriteLine("Se preparó un cafe FUERTE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("No se puede preparar el café por falta de líquido");
            //    Console.WriteLine();
            //}
        }
        public void PrepararConLeche()
        {
            //if (Agua > 50 && Cafe > 80 && Leche > 70)
            //{
            //    //Agua = Agua - 130;
            //    Agua -= 50;
            //    Cafe -= 80;
            //    Leche -= 70;

            //    Console.WriteLine();
            //    Console.WriteLine("Se preparó un cafe CON LECHE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("No se puede preparar el café por falta de líquido");
            //    Console.WriteLine();
            //}
        }

        public void RellenarLeche()
        {
            Leche.Rellenar("Leche");
        }
        public void RellenarCafe()
        {
            Cafe.Rellenar("Cafe");
        }
        public void RellenarAgua()
        {
            Agua.Rellenar("Agua");
        }

    }
}
