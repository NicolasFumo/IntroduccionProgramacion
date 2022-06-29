using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFacturas.Clases
{
    public class Factura
    {
        public Factura()
        {
            Emisor = new RazonSocial();
            Receptor = new RazonSocial();
            ListadoItems = new List<ItemFactura>();
        }

        public int NroFactura { get; set; }
        public string TipoFactura { get; set; }
        public List<ItemFactura> ListadoItems { get; set; }
        public RazonSocial Emisor { get; set; }
        public RazonSocial Receptor { get; set; }
    }
}
