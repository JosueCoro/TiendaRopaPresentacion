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
    public partial class LOGIN_1 : Form
    {
        public LOGIN_1()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            UsuarioLogin usuario = new userdatos().ValidarUsuario(textBoxCorreo.Text, textBoxContraseña.Text);
            if (usuario != null)
            {
                this.Hide();
                SISTEM_MENU formRegistroUsuario = new SISTEM_MENU();
                formRegistroUsuario.Show();
                //MessageBox.Show("Usuario correcto");
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
