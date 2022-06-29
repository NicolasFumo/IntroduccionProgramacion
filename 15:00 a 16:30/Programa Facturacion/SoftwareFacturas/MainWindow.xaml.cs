using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using SoftwareFacturas.Clases;

namespace SoftwareFacturas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Factura> ListadoFacturas;

        public MainWindow()
        {
            InitializeComponent();

            ListadoFacturas = new List<Factura>();
        }

        private void btnCargarFactura_Click(object sender, RoutedEventArgs e)
        {
            VentanaCargarFactura ventanaCargarFactura = new VentanaCargarFactura();
            ventanaCargarFactura.ShowDialog();
        }
    }
}
