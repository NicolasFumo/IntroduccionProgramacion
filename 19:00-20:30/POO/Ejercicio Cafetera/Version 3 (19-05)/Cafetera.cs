using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera19hs
{
    public class Cafetera
    {
        Contenedor Agua = new Contenedor();
        Contenedor Cafe = new Contenedor();
        Contenedor Leche = new Contenedor();
        public void Encender()
        {
            Console.Write("Ingrese cantidad de agua: ");
            Agua.Liquido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de cafe: ");
            Cafe.Liquido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de leche: ");
            Leche.Liquido = int.Parse(Console.ReadLine());
        }
        public void MostrarContenedores()
        {
            Console.WriteLine("");

            Agua.MostrarContenido("Agua");
            Cafe.MostrarContenido("Cafe");
            Leche.MostrarContenido("Leche");

            //Console.WriteLine($"Agua: {Agua} cc.");
            //Console.WriteLine($"Cafe: {Cafe} cc.");
            //Console.WriteLine($"Leche: {Leche} cc.");
            Console.WriteLine("");
        }
        public void PrepararConLeche()
        {
            //if (Agua >= 50 && Cafe >= 80 && Leche >= 70)
            //{
            //    Agua -= 50;
            //    Cafe -= 80;
            //    Leche -= 70;

            //    Console.WriteLine("Se ha preparado un cafe CON LECHE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine("No se puede preparar el café CON LECHE por falta de líquido");
            //}
        }
        public void PrepararFuerte()
        {
            //if (Agua >= 90 && Cafe >= 110)
            //{
            //    Agua -= 90;
            //    Cafe -= 110;

            //    Console.WriteLine("Se ha preparado un cafe FUERTE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine("No se puede preparar el café FUERTE por falta de líquido");
            //}
        }
        public void PrepararSuave()
        {
            //if (Agua >= 130 && Cafe >= 70)
            //{
            //    //Agua = Agua - 130;
            //    Agua -= 130;
            //    Cafe -= 70;

            //    Console.WriteLine("Se ha preparado un cafe SUAVE");
            //    Console.WriteLine();

            //    MostrarContenedores();
            //}
            //else
            //{
            //    Console.WriteLine("No se puede preparar el café SUAVE por falta de líquido");
            //}
        }
        public void RellenarAgua()
        {
            Console.WriteLine("Ingrese cantidad de agua a rellenar: ");
            int RellenoAgua = int.Parse(Console.ReadLine());

            Agua.Rellenar(RellenoAgua);
            
        }
        public void RellenarCafe()
        {
            //Console.WriteLine("Ingrese cantidad de cafe a rellenar: ");
            //int RellenoCafe = int.Parse(Console.ReadLine());

            //if (Cafe + RellenoCafe > 1000)
            //{
            //    Console.WriteLine("El valor supera el contendor");
            //    MostrarContenedores();
            //}
            //else
            //{
            //    Cafe += RellenoCafe;
            //    MostrarContenedores();
            //}
        }
        public void RellenarLeche()
        {
            //Console.WriteLine("Ingrese cantidad de leche a rellenar: ");
            //int RellenoLeche = int.Parse(Console.ReadLine());

            //if (Leche + RellenoLeche > 1000)
            //{
            //    Console.WriteLine("El valor supera el contendor");
            //    MostrarContenedores();
            //}
            //else
            //{
            //    Leche += RellenoLeche;
            //    MostrarContenedores();
            //}
        }

    }
}
