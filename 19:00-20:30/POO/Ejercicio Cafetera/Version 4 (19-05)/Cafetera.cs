using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera19hs
{
    public class Cafetera
    {
        Contenedor ContenedorAgua = new Contenedor(0,1000);
        Contenedor ContenedorCafe = new Contenedor(0,1000);
        Contenedor ContenedorLeche = new Contenedor(0,600);
        public void Encender()
        {
            ContenedorAgua.CargaInicial("Agua");
            ContenedorCafe.CargaInicial("Cafe");
            ContenedorLeche.CargaInicial("Leche");
        }
        public void MostrarContenedores()
        {
            Console.WriteLine("");

            ContenedorLeche.MostrarContenido("Leche");
            ContenedorAgua.MostrarContenido("Agua");
            ContenedorCafe.MostrarContenido("Cafe");

            Console.WriteLine("");
        }
        public void PrepararConLeche()
        {
            bool sePuedeRestarAgua = ContenedorAgua.AlcanzaLiquido(50);
            bool sePuedeRestarCafe = ContenedorCafe.AlcanzaLiquido(80);
            bool sePuedeRestarLeche = ContenedorLeche.AlcanzaLiquido(70);

            if(sePuedeRestarAgua && sePuedeRestarCafe && sePuedeRestarLeche)
            {
                ContenedorAgua.ExtraerLiquido(50);
                ContenedorCafe.ExtraerLiquido(80);
                ContenedorLeche.ExtraerLiquido(70);

                Console.WriteLine("Se preparo con cafe con leche");
            }
            else
            {
                if (!sePuedeRestarAgua)
                {
                    Console.WriteLine("No se puede preparar el café CON LECHE por falta de Agua");

                }
                if (!sePuedeRestarCafe)
                {
                    Console.WriteLine("No se puede preparar el café CON LECHE por falta de Cafe");

                }
                if (!sePuedeRestarLeche)
                {
                    Console.WriteLine("No se puede preparar el café CON LECHE por falta de Leche");

                }
            }
            
        }
        public void PrepararFuerte()
        {
            bool sePuedeRestarAgua = ContenedorAgua.AlcanzaLiquido(90);
            bool sePuedeRestarCafe = ContenedorCafe.AlcanzaLiquido(110);

            if (sePuedeRestarAgua && sePuedeRestarCafe)
            {
                ContenedorAgua.ExtraerLiquido(90);
                ContenedorCafe.ExtraerLiquido(110);

                Console.WriteLine("Se preparo con cafe con FUERTE");
            }
            else
            {
                if (!sePuedeRestarAgua)
                {
                    Console.WriteLine("No se puede preparar el café FUERTE por falta de Agua");

                }
                if (!sePuedeRestarCafe)
                {
                    Console.WriteLine("No se puede preparar el café FUERTE por falta de Cafe");

                }
            }
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

            ContenedorAgua.Rellenar(RellenoAgua);
            
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
