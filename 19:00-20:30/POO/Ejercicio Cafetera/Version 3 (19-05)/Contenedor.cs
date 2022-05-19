using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera19hs
{
    public class Contenedor
    {
        public int Maximo;
        public int Minimo;
        public int Liquido;

        public void Rellenar(int cantidad)
        {
            if (Liquido + cantidad > 1000)
            {
                Console.WriteLine("El valor supera el contendor");
            }
            else
            {
                Liquido += cantidad;
            }
        }

        public void MostrarContenido(string tipoLiquido)
        {
            Console.WriteLine($"La cantidad de {tipoLiquido} es: {Liquido}");
        }
    }
}
