using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFacturas.Clases
{
    public class ItemFactura
    {
        public string Descripcion { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
