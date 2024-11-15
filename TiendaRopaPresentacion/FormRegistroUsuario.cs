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
using CapaModelo;

namespace TiendaRopaPresentacion
{
    
    public partial class FormRegistroUsuario : Form
    {
        private Usuario Usuario = new Usuario();
        private int idUsuarioSeleccionado;

        public FormRegistroUsuario()
        {
            InitializeComponent();
            MostrarUsuarios();
            CargarRoles();
        }

        private void textBoxCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                //cargar los datos a los textbox
                idUsuarioSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                textBoxCI.Text = dataGridView1.Rows[e.RowIndex].Cells["CI"].Value.ToString();
                textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                textBoxCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                textBoxContra.Text = dataGridView1.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                comboBoxRol.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["IdRol"].Value;

                
            }
        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            Usuario.CI = textBoxCI.Text;
            Usuario.NombreCompleto = textBoxname.Text;
            Usuario.Correo = textBoxCorreo.Text;
            Usuario.Contraseña = textBoxContra.Text;
            Usuario.IdRol = Convert.ToInt32(comboBoxRol.SelectedValue);
            Usuario.Estado = "A";

            userdatos usuarioDatos = new userdatos();
            usuarioDatos.CrearUsuario(Usuario);

            //MessageBox.Show("Usuario creado correctamente");
            MostrarUsuarios();

        }
        private void LimpiarForm()
        {
            textBoxCI.Text = "";
            textBoxname.Text = "";
            textBoxCorreo.Text = "";
            textBoxContra.Text = "";
            comboBoxRol.SelectedIndex = -1;
        }

        private void MostrarUsuarios()
        {
            userdatos usuariosDatos = new userdatos();
            DataTable dtUsuarios = usuariosDatos.MostrarUser();

            dataGridView1.DataSource = dtUsuarios;
        }
        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();  
        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {

        }
        private void CargarRoles()
        {
            rolesdatos rolesDatos = new rolesdatos();
            DataTable dtRoles = rolesDatos.ObtenerRoles();
            comboBoxRol.DataSource = dtRoles;
            comboBoxRol.DisplayMember = "Nombre_Rol";
            comboBoxRol.ValueMember = "IdRol";
            comboBoxRol.SelectedIndex = -1;
        }
        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioactualizado = new Usuario();
                usuarioactualizado.IdUsuario = idUsuarioSeleccionado;
                usuarioactualizado.CI = textBoxCI.Text;
                usuarioactualizado.NombreCompleto = textBoxname.Text;
                usuarioactualizado.Correo = textBoxCorreo.Text;
                usuarioactualizado.Contraseña = textBoxContra.Text;
                usuarioactualizado.IdRol = Convert.ToInt32(comboBoxRol.SelectedValue);
                usuarioactualizado.Estado = "A";

                userdatos usuarioDatos = new userdatos();
                usuarioDatos.ActualizarUsuario(usuarioactualizado);

                //MessageBox.Show("Usuario actualizado correctamente");
                MostrarUsuarios();  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value);
                userdatos usuarioDatos = new userdatos();
                usuarioDatos.EliminarUsuario(idUsuarioSeleccionado);
                MostrarUsuarios();


            }
        }
    }
}
