using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioCafetera
{
    public class Contenedor
    {
        public int Contenido;
        public int Maximo;
        public int Minimo;

        public Contenedor(int maximo, int minimo)
        {
            Maximo = maximo;
            Minimo = minimo;
        }

        public Contenedor()
        {

        }

        public void MostrarContenido(string tipoLiquido)
        {
            Console.WriteLine($"El contenido de {tipoLiquido} es: {Contenido}");
        }

        public void Rellenar(string tipoLiquido)
        {
            Console.Write($"Ingrese cantidad de {tipoLiquido}: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (Contenido + cantidad > Maximo)
            {
                Contenido = Maximo;
            }
            else
            {
                Contenido += cantidad;
            }
        }

        public bool AlcanzaLiquido(int cantidadAUsar)
        {
            if (Contenido < cantidadAUsar)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
