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
    public partial class MarcaRegistro : Form
    {
        MarcaDatos marcaDatos = new MarcaDatos();
        public MarcaRegistro()
        {
            InitializeComponent();
            mostrarmarcas();
        }
        private void mostrarmarcas()
        {
            dataGridView1.DataSource = marcaDatos.MostrarMarca();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {

        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
