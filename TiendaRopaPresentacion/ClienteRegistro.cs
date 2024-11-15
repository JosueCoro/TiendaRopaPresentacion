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
    public partial class ClienteRegistro : Form
    {
        private Categoria categoria = new Categoria();
        private int idcategoriaSeleccionado;
        public ClienteRegistro()
        {
            InitializeComponent();
            mostrarcliente();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void mostrarcliente()
        {
            CapaDatos.Cliente cliente = new CapaDatos.Cliente();
            dataGridView1.DataSource = cliente.MostrarClientes();
        }
        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            Clienteclass cliente = new Clienteclass();
            cliente.CI = textBoxCI.Text;
            cliente.NombreCompleto = textBoxname.Text;
            cliente.Correo = textBoxCorreo.Text;
            cliente.Telefono = textBoxTelfono.Text;
            cliente.Estado = "A";
            cliente.IdUsuario = 1;

            Cliente clienteDatos = new Cliente();
            clienteDatos.InsertarCliente(cliente);

            //MessageBox.Show("Cliente creado correctamente");
            mostrarcliente();
            LimpiarFormulario();


        }
        private void LimpiarFormulario()
        {
            textBoxCI.Text = "";
            textBoxname.Text = "";
            textBoxCorreo.Text = "";
            textBoxTelfono.Text = "";
        }
        private void textBoxCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelfono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                //cargar los datos a los textbox
                idcategoriaSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdCliente"].Value);
                textBoxCI.Text = dataGridView1.Rows[e.RowIndex].Cells["CI"].Value.ToString();
                textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                textBoxCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                textBoxTelfono.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                int idClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCliente"].Value);
                Clienteclass cliente = new Clienteclass();
                cliente.IdCliente = idClienteSeleccionado;
                Cliente clienteDatos = new Cliente();
                clienteDatos.EliminarCliente(cliente);

                //MessageBox.Show("Cliente eliminado correctamente");
                LimpiarFormulario();
                mostrarcliente();
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                Clienteclass clienteClass = new Clienteclass();
                clienteClass.IdCliente = idcategoriaSeleccionado;
                clienteClass.CI = textBoxCI.Text;
                clienteClass.NombreCompleto = textBoxname.Text;
                clienteClass.Correo = textBoxCorreo.Text;
                clienteClass.Telefono = textBoxTelfono.Text;
                clienteClass.Estado = "A";
                clienteClass.IdUsuario = 1;

                cliente.ActualizarCliente(clienteClass);
                mostrarcliente();
                LimpiarFormulario();

                //MessageBox.Show("Cliente actualizado correctamente");
            }
            catch 
            {
                MessageBox.Show("Error al actualizar el cliente");
            }
        }
    }
}
