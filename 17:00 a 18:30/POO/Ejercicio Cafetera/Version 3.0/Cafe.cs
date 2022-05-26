using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioCafetera
{
    public class Cafe
    {
        public Cafe(int cafe, int agua, int leche, int Capacidad, string tipoCafe)
        {
            CantidadCafe = cafe;
            CantidadAgua = agua;
            CantidadLeche = leche;
            this.Capacidad = Capacidad;
            TipoCafe = tipoCafe;
        }

        public int CantidadCafe;
        public int CantidadAgua;
        public int CantidadLeche;
        public int Capacidad;
        public string TipoCafe;
    }
}
