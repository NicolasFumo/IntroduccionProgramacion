using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCafetera2
{
    public class Cafetera
    {
        public Contenedor ContenedorAgua;
        public Contenedor ContenedorCafe;
        public Contenedor ContenedorLeche;

        public Cafetera()
        {
            ContenedorAgua = new Contenedor("Agua", 0, 1000);
            ContenedorCafe = new Contenedor("Cafe", 0, 1000);
            ContenedorLeche = new Contenedor("Leche", 0, 1000);
        }

        public void PrepararSuave()
        {
            //Cafe = Cafe - 90;
            ContenedorCafe.Contenido -= 70;
            ContenedorAgua.Contenido -= 130;

            Console.WriteLine("Se ha preparado un cafe SUAVE");

            MostrarContenido();
        }

        public void PrepararFuerte()
        {
            ContenedorCafe.Contenido -= 110;
            ContenedorAgua.Contenido -= 90;

            Console.WriteLine("Se ha preparado un cafe FUERTE");

            MostrarContenido();
        }

        public void PrepararConLeche()
        {
            ContenedorCafe.Contenido -= 80;
            ContenedorAgua.Contenido -= 50;
            ContenedorLeche.Contenido -= 70;

            Console.WriteLine("Se ha preparado un cafe CON LECHE");

            MostrarContenido();
        }

        public void RellenarAgua()
        {
            ContenedorAgua.Rellenar();
        }

        public void RellenarCafe()
        {
            ContenedorCafe.Rellenar();
        }

        public void RellenarLeche()
        {
            ContenedorLeche.Rellenar();
        }

        public void Encender()
        {
            ContenedorAgua.Inicializar();
            ContenedorCafe.Inicializar();
            ContenedorLeche.Inicializar();

        }

        public void MostrarContenido()
        {
            Console.WriteLine("");

            ContenedorAgua.MostrarContenido();
            ContenedorCafe.MostrarContenido();
            ContenedorLeche.MostrarContenido();

            Console.WriteLine("");
        }
    }
}
