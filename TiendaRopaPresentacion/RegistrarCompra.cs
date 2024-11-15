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
    public partial class RegistrarCompra : Form
    {
        private Producto producto = new Producto();
        private Proveedor proveedor = new Proveedor();
        private CompraDatos compradatos = new CompraDatos();
        CompraClass compra = new CompraClass();
        public RegistrarCompra()
        {
            InitializeComponent();
            cargarproducto();
            cargarproveedor();
        }

        private void cargarproducto()
        {
            comboBoxProducto.DataSource = producto.ObtenerProducto();
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "IdProducto";
            comboBoxProducto.SelectedIndex = -1;
        }
        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargarproveedor()
        {
            comboBoxproveedor.DataSource = proveedor.ObtenerProveedor();
            comboBoxproveedor.DisplayMember = "NombreCompleto";
            comboBoxproveedor.ValueMember = "IdProveedor";
            comboBoxproveedor.SelectedIndex = -1;
        }

        private void comboBoxproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (compra.Detalles == null)
                {
                    compra.Detalles = new List<CompraClass.DetalleCompra>();
                }

                compra.Detalles.Clear();

                if (string.IsNullOrWhiteSpace(textBoxtipoDoc.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNumDoc.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTotal.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos en la lista de compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                compra.IdProveedor = Convert.ToInt32(comboBoxproveedor.SelectedValue);
                compra.IdUsuario = 1; 
                compra.TipoDocumento = textBoxtipoDoc.Text;
                compra.NumeroDocumento = textBoxNumDoc.Text;
                compra.MontoTotal = Convert.ToDecimal(textBoxTotal.Text);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ID_PRODUCTO"].Value != null)
                    {
                        CompraClass.DetalleCompra detalle = new CompraClass.DetalleCompra
                        {
                            IdProducto = Convert.ToInt32(row.Cells["ID_PRODUCTO"].Value),
                            PrecioCompra = Convert.ToDecimal(row.Cells["PRECIO_COMPRA"].Value),
                            PrecioVenta = Convert.ToDecimal(row.Cells["PRECIO_VENTA"].Value),
                            Cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value)
                        };

                        // Agregar el detalle a la lista
                        compra.Detalles.Add(detalle);
                    }
                }

                compradatos.RegistrarCompra(compra);

                //MessageBox.Show("Compra registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void numericUpDowncantidad_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarFormulario()
        {
            comboBoxproveedor.SelectedIndex = -1;
            comboBoxProducto.SelectedIndex = -1;
            textBoxtipoDoc.Clear();
            textBoxNumDoc.Clear();
            textBoxTotal.Clear();
            dataGridView1.Rows.Clear();
        }

        private void buttonañadircarro_Click(object sender, EventArgs e)
        {
            //validacion de campos
            if (comboBoxProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            //string producto = comboBoxProducto.Text;
            int idproducto = Convert.ToInt32(comboBoxProducto.SelectedValue);
            string nombreproducto = producto.ObtenerNombrePorId(idproducto);
            decimal preciocompra = ObtenerPrecioPorId(idproducto);
            decimal precioventa = ObtenerPrecioPorId(idproducto);
            int cantidad = Convert.ToInt32(numericUpDowncantidad.Value);
            decimal total = cantidad * preciocompra;

            dataGridView1.Rows.Add(idproducto, nombreproducto, cantidad, preciocompra, precioventa, total);
            calculartotal();
        }
        private decimal ObtenerPrecioPorId(int idproducto)
        {
            return producto.ObtenerPrecioPorId(idproducto);
        }
        private void calculartotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["TOTAL"].Value);
            }
            textBoxTotal.Text = total.ToString();

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtipoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
