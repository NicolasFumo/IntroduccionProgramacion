using SoftwareFacturas.Clases;
using System.Windows;

namespace SoftwareFacturas
{
    /// <summary>
    /// Lógica de interacción para VentanaCargarFactura.xaml
    /// </summary>
    public partial class VentanaCargarFactura : Window
    {
        public Factura FacturaACargar;
        public VentanaCargarFactura()
        {
            InitializeComponent();

            FacturaACargar = new Factura();

            
        }

        private void btnCargarItemFactura_Click(object sender, RoutedEventArgs e)
        {
            ItemFactura item = new ItemFactura();

            item.Descripcion = txtDescripcion.Text;
            item.PrecioUnitario = decimal.Parse(txtPrecio.Text);
            item.Cantidad = int.Parse(txtCantidad.Text);

            FacturaACargar.ListadoItems.Add(item);

            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";

            dtgItemsFactura.ItemsSource = null;
            dtgItemsFactura.ItemsSource = FacturaACargar.ListadoItems;
        }
    }
}
