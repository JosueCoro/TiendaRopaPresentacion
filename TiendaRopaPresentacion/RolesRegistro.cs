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
    public partial class RolesRegistro : Form
    {
        rolesdatos roles = new rolesdatos();
        public RolesRegistro()
        {
            InitializeComponent();
            mostrarroles();
        }
        private void mostrarroles()
        {
            dataGridView1.DataSource = roles.MostrarRoles();
        }
        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {

        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
