using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioCafetera
{
    public class Cafetera
    {
        public Contenedor ContenedorLeche = new Contenedor(800, 0);
        public Contenedor ContenedorAgua = new Contenedor(1000, 0);
        public Contenedor ContenedorCafe = new Contenedor(1000, 0);

        public Cafe CafeSuave = new Cafe(70, 130, 0, 200, "Cafe suave");
        public Cafe CafeFuerte = new Cafe(110, 90, 0, 200, "Cafe fuerte");
        public Cafe CafeConLeche = new Cafe(80, 50, 70, 200, "Cafe con leche");

        public void Encender()
        {
            Console.Write("Ingrese cantidad Leche: ");
            ContenedorLeche.Contenido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Cafe: ");
            ContenedorCafe.Contenido = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad Agua: ");
            ContenedorAgua.Contenido = int.Parse(Console.ReadLine());
        }
        public void MostrarContenedores()
        {
            Console.WriteLine();
            ContenedorLeche.MostrarContenido("Leche");
            ContenedorAgua.MostrarContenido("Agua");
            ContenedorCafe.MostrarContenido("Cafe");
            Console.WriteLine();
        }
        public void PrepararSuave()
        {
            if (ContenedorAgua.AlcanzaLiquido(CafeSuave.CantidadAgua) 
                && ContenedorCafe.AlcanzaLiquido(CafeSuave.CantidadCafe))
            {
                ContenedorAgua.Contenido -= CafeSuave.CantidadAgua;
                ContenedorCafe.Contenido -= CafeSuave.CantidadCafe;

                Console.WriteLine();
                Console.WriteLine($"Se preparó un {CafeSuave.TipoCafe}");
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
            ContenedorLeche.Rellenar("Leche");
        }
        public void RellenarCafe()
        {
            ContenedorCafe.Rellenar("Cafe");
        }
        public void RellenarAgua()
        {
            ContenedorAgua.Rellenar("Agua");
        }

    }
}
