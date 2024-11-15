using CapaDatos;
using CapaModelo;
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
    public partial class CategoriaRegistro : Form
    {
        private Categoria Usuario = new Categoria();
        private int idCategoriaSeleccionado;
        public CategoriaRegistro()
        {
            InitializeComponent();
            MostrarCategoria();
        }
        private void MostrarCategoria()
        {
            categoriaDatos categoriaDato = new categoriaDatos();
            dataGridView1.DataSource = categoriaDato.MostrarCategoria();
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
