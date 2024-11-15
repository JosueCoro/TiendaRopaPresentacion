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
    public partial class ProductoRegistro : Form
    {
        Producto producto = new Producto();
        categoriaDatos categoria = new categoriaDatos();
        MarcaDatos marca = new MarcaDatos();
        ProductoClass productoClass = new ProductoClass();
        public ProductoRegistro()
        {
            InitializeComponent();
            mostrarproducto();
            cargarcategoria();
            cargarMarca();
        }
        private void mostrarproducto()
        {
            dataGridView1.DataSource = producto.MostrarProducto();
        }
        private void buttonmostrar_Click(object sender, EventArgs e)
        {

        }
        private void cargarcategoria()
        {
            comboBoxcategoria.DataSource = categoria.MostrarCategoria();
            comboBoxcategoria.DisplayMember = "Nombre";
            comboBoxcategoria.ValueMember = "IdCategoria";

        }
        private void comboBoxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargarMarca()
        {
            comboBoxMarca.DataSource = marca.MostrarMarca();
            comboBoxMarca.DisplayMember = "NombreMarca";
            comboBoxMarca.ValueMember = "IdMarca";

        }
        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {

            //validar campos
            if (textBoxname.Text == "")
            {
                MessageBox.Show("El campo nombre es obligatorio");
                return;
            }
            if (textBoxdescripcion.Text == "")
            {
                MessageBox.Show("El campo descripcion es obligatorio");
                return;
            }
            if (textBoxstock.Text == "")
            {
                MessageBox.Show("El campo stock es obligatorio");
                return;
            }
            productoClass.Nombre = textBoxname.Text;
            productoClass.Descripcion = textBoxdescripcion.Text;
            productoClass.Stock = Convert.ToInt32(textBoxstock.Text);
            productoClass.IdCategoria = Convert.ToInt32(comboBoxcategoria.SelectedValue);
            productoClass.IdMarca = Convert.ToInt32(comboBoxMarca.SelectedValue);
            productoClass.PrecioCompra = Convert.ToSingle(textBoxCompra.Text);
            productoClass.PrecioVenta = Convert.ToSingle(textBoxVenta.Text);
            productoClass.Estado = "A";

            if (producto.CrearProducto(productoClass))
            {
                MessageBox.Show("Producto creado correctamente");
                mostrarproducto();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al crear el producto");
            }

        }
        private void Limpiar()
        {
            textBoxname.Clear();
            textBoxdescripcion.Clear();
            textBoxstock.Clear();
            textBoxCompra.Clear();
            textBoxVenta.Clear();
            comboBoxcategoria.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            //actualizar producto
            if (textBoxname.Text == "")
            {
                MessageBox.Show("El campo nombre es obligatorio");
                return;
            }

            if (textBoxdescripcion.Text == "")
            {
                MessageBox.Show("El campo descripcion es obligatorio");
                return;
            }
            if (textBoxstock.Text == "")
            {
                MessageBox.Show("El campo stock es obligatorio");
                return;
            }
            productoClass.IdProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value);
            productoClass.Nombre = textBoxname.Text;
            productoClass.Descripcion = textBoxdescripcion.Text;
            productoClass.Stock = Convert.ToInt32(textBoxstock.Text);
            productoClass.IdCategoria = Convert.ToInt32(comboBoxcategoria.SelectedValue);
            productoClass.IdMarca = Convert.ToInt32(comboBoxMarca.SelectedValue);
            productoClass.PrecioCompra = Convert.ToSingle(textBoxCompra.Text);
            productoClass.PrecioVenta = Convert.ToSingle(textBoxVenta.Text);
            productoClass.Estado = "A";

            producto.ActualizarProducto(productoClass);
            MessageBox.Show("Producto actualizado correctamente");
            mostrarproducto();
            Limpiar();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //doble click en la fila del datagridview para cargar los datos en los textbox
            textBoxname.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxdescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            textBoxstock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            comboBoxcategoria.SelectedValue = dataGridView1.CurrentRow.Cells["IdCategoria"].Value;
            comboBoxMarca.SelectedValue = dataGridView1.CurrentRow.Cells["IdMarca"].Value;
            textBoxCompra.Text = dataGridView1.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            textBoxVenta.Text = dataGridView1.CurrentRow.Cells["PrecioVenta"].Value.ToString();

        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            //eliminar producto
            if (MessageBox.Show("¿Está seguro de eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                producto.EliminarProducto(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value));
                MessageBox.Show("Producto eliminado correctamente");
                mostrarproducto();
                Limpiar();
            }
        }
    }
}
