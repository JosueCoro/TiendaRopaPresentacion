using CapaDatos;
using CapaModelo;
using System;
using System.Data.SqlClient;
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
    public partial class VentaRegistro : Form
    {
        private Producto producto = new Producto();
        private VentaDatos ventadatos = new VentaDatos();
        VentaClass venta = new VentaClass();

        public VentaRegistro()
        {
            InitializeComponent();
            cargarclientes();
            cargarproducto();
        }
        private void cargarclientes()
        {
            CapaDatos.Cliente clienteDatos = new CapaDatos.Cliente();
            comboBoxCliente.DataSource = clienteDatos.ObtenerIdCliente();
            comboBoxCliente.DisplayMember = "NombreCompleto";
            comboBoxCliente.ValueMember = "IdCliente";
            comboBoxCliente.SelectedIndex = -1;
        }
        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            VentaClass venta = new VentaClass();
            venta.IdUsuario = 1;  // El IdUsuario puede ser el usuario logueado
            venta.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue); // El IdCliente puede provenir de un comboBox
            venta.MontoPago = Convert.ToDecimal(textBoxMontoPago.Text);
            venta.MontoCambio = Convert.ToDecimal(textBoxMontoCambio.Text);
            venta.MontoTotal = Convert.ToDecimal(textBoxTotal.Text);

            // Crear la lista de detalles de la venta
            venta.Detalles = new List<VentaClass.DetalleVenta>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID_PRODUCTO"].Value != null)
                {
                    VentaClass.DetalleVenta detalle = new VentaClass.DetalleVenta();
                    detalle.IdProducto = Convert.ToInt32(row.Cells["ID_PRODUCTO"].Value);
                    detalle.PrecioVenta = Convert.ToDecimal(row.Cells["PRECIO_VENTA"].Value);
                    detalle.Cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value);

                    venta.Detalles.Add(detalle);
                }
            }
            VentaDatos ventaDatos = new VentaDatos();
            // Llamar a la función para registrar la venta
            ventaDatos.RegistrarVenta(venta);
            LimpiarForm();

            //MessageBox.Show("Venta registrada correctamente.");
        }
        private void LimpiarForm()
        {
            comboBoxCliente.SelectedIndex = -1;
            comboBoxProducto.SelectedIndex = -1;
            //textBoxMontoPago.Clear();
            //textBoxMontoCambio.Clear();
            textBoxTotal.Clear();
            dataGridView1.Rows.Clear();
        }
        private void buttonañadircarro_Click(object sender, EventArgs e)
        {
            //validacion de campo
            if (comboBoxProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            int idproducto = Convert.ToInt32(comboBoxProducto.SelectedValue);
            string nombreproducto = comboBoxProducto.Text;
            
            int cantidad = Convert.ToInt32(numericUpDowncantidad.Value);
            decimal precioventa = ObtenerPrecioPorId(idproducto);
            decimal total = cantidad * precioventa;
            //agregar a la lista
            dataGridView1.Rows.Add(idproducto, nombreproducto, cantidad, precioventa, total);
            calculartotal();

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
        private decimal ObtenerPrecioPorId(int idproducto)
        {
            return producto.ObtenerPrecioPorId(idproducto);
        }

        private void textBoxMontoPago_TextChanged(object sender, EventArgs e)
        {
            calcularcambio();
        }

        //funcion para calcular el cambio
        private void calcularcambio()
        {
            decimal total = Convert.ToDecimal(textBoxTotal.Text);
            decimal monto = Convert.ToDecimal(textBoxMontoPago.Text);
            decimal cambio = monto - total;
            textBoxMontoCambio.Text = cambio.ToString();
        }
        private void textBoxMontoCambio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
