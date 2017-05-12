using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmProductos : Form
    {
        private List<Producto> ProductsList;
        private List<string> NombresProductos;

        public frmProductos()
        {
            InitializeComponent();
            NombresProductos = new List<string>();
            ProductsList = General.TraerProductos();
            LlenarTabla();

        }

        private void LlenarTabla()
        {
            foreach (var producto in ProductsList)
            {                
                gdvProductos.Rows.Add(producto.Descripcion, producto.Tipo, producto.Monto, cEstat.ThreeState = producto.Estado);
            }
        }

        private void gdvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
