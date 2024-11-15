using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaRopaPresentacion
{
    public partial class ProveedorRegistro : Form
    {
        Proveedor proveedor = new Proveedor();
        public ProveedorRegistro()
        {
            InitializeComponent();
            cargarProveedor();
        }
        private void cargarProveedor()
        {
            dataGridView1.DataSource = proveedor.MostrarProveedor();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }

        private void ProveedorRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
