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
    public partial class SISTEM_MENU : Form
    {
        public SISTEM_MENU()
        {
            InitializeComponent();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaRegistro frm = new VentaRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);

        }

        private void panelCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uSUARIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abrir  FormRegistroUsuario enventana en el panelCuerpo
            FormRegistroUsuario frm = new FormRegistroUsuario();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            //eliminar los bordes del FormRegistroUsuario
            frm.FormBorderStyle = FormBorderStyle.None;
            //limpiar el panelCuerpo
            panelCuerpo.Controls.Clear();
            //agregar el FormRegistroUsuario al panelCuerpo
            panelCuerpo.Controls.Add(frm);

        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesRegistro frm = new RolesRegistro();
            frm.TopLevel = false;

            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteRegistro frm = new ClienteRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoRegistro frm = new ProductoRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcaRegistro frm = new MarcaRegistro();

            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);

        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroInventario frm = new RegistroInventario();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void cOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCompra frm = new RegistrarCompra();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);

        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorRegistro frm = new ProveedorRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaRegistro frm = new CategoriaRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductoRegistro frm = new ProductoRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaRegistro frm = new CategoriaRegistro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
            panelCuerpo.Controls.Clear();
            panelCuerpo.Controls.Add(frm);
        }
    }
}
