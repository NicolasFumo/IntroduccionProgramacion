using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCafetera2
{
    public class Contenedor
    {
        public int Maximo;
        public int Minimo;
        public int Contenido;
        public string TipoContenido;

        public Contenedor(string tipo, int min, int max)
        {
            TipoContenido = tipo;
            Minimo = min;
            Maximo = max;
        }

        public void Rellenar()
        {
            Console.WriteLine($"Ingrese cantidad de {TipoContenido} a rellenar: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (Contenido + cantidad > Maximo)
            {
                Contenido = Maximo;
            }
            else
            {
                Contenido += cantidad;
            }

            MostrarContenido();
        }

        public void Inicializar()
        {
            int cantidad;

            do
            {
                Console.Write($"Cantidad de {TipoContenido}: ");
                cantidad = int.Parse(Console.ReadLine());

            } while (cantidad < Minimo || cantidad > Maximo);

            Contenido = cantidad;
        }

        public void MostrarContenido()
        {
            Console.WriteLine($"La cantidad de {TipoContenido} es {Contenido}.");
        }
    }
}
