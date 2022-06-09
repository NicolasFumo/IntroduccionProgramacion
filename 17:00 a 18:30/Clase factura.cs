 public RazonSocial Emisor;
        public RazonSocial Receptor;
        public int NroFactura;
        public char TipoFactura;
        public List<ItemFactura> ItemsFactura;

        public Factura()
        {
            Emisor = new RazonSocial();
            Receptor = new RazonSocial();
            ItemsFactura = new List<ItemFactura>();
        }
