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
    public partial class RegistroInventario : Form
    {
        InventarioDatos inventarioDatos = new InventarioDatos();
        Producto inventarioProducto = new Producto();
        ALmacenDatos ALmacenDatos = new ALmacenDatos();
        public RegistroInventario()
        {
            InitializeComponent();
            RegistroInventario_Load(null, null);
            cargarproductos();
            cargaralmacen();
        }

        private void RegistroInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inventarioDatos.MostrarInventario();
        }
        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargarproductos()
        {
            comboBoxproducto.DataSource = inventarioProducto.ObtenerProducto();
            comboBoxproducto.DisplayMember = "Nombre";
            comboBoxproducto.ValueMember = "IdProducto";

        }
        private void comboBoxproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargaralmacen()
        {
            comboBoxAlmacen.DataSource = ALmacenDatos.ObtenerAlmacen();
            comboBoxAlmacen.DisplayMember = "Nombre";
            comboBoxAlmacen.ValueMember = "IdAlmacen";
            comboBoxAlmacen.SelectedIndex = -1;

        }
        private void comboBoxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
