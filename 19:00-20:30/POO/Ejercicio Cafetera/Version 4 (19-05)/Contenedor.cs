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

        public Contenedor(int min, int max)
        {
            Maximo = max;
            Minimo = min;
        }
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
        public bool AlcanzaLiquido(int cantidad)
        {
            if (cantidad <= Liquido)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExtraerLiquido(int cantidad)
        {
            Liquido -= cantidad;
        }
        public void CargaInicial(string tipoLiquido)
        {
            do
            {
                Console.Write($"Ingrese cantidad de {tipoLiquido}: ");
                Liquido = int.Parse(Console.ReadLine());

            } while (Liquido < Minimo || Liquido > Maximo);

        }
    }
}
