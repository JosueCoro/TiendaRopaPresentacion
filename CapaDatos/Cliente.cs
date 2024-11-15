using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using CapaModelo;
using System.Windows.Forms;


namespace CapaDatos
{
    public class Cliente
    {
        private string conexion = new conexion_bd().GetCadenaConexion();
        private string cadenaConexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        public DataTable ObtenerIdCliente()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("select IdCliente, NombreCompleto FROM CLIENTE", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtMesas = new DataTable();
                da.Fill(dtMesas);
                return dtMesas;
            }
        }

        //mostrar clientes
        public DataTable MostrarClientes()
        {
            DataTable dtClientes = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dtClientes.Load(dr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los clientes:" + ex.Message);
            }

            return dtClientes;
        }
        //insertar clientes referencias con la clase Cliente
        public void InsertarCliente(Clienteclass cliente)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE (CI, NombreCompleto, Correo, Telefono, Estado, IdUsuario) VALUES (@CI, @NombreCompleto, @Correo, @Telefono, @Estado, @IdUsuario)", cn))
                    {
                        cmd.Parameters.AddWithValue("@CI", cliente.CI);
                        cmd.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                        cmd.Parameters.AddWithValue("@IdUsuario", cliente.IdUsuario);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message);
            }
        }

        //Actualizar Cliente
        public void ActualizarCliente(Clienteclass cliente)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE CLIENTE SET CI = @CI, NombreCompleto = @NombreCompleto, Correo = @Correo, Telefono = @Telefono, Estado = @Estado, IdUsuario = @IdUsuario WHERE IdCliente = @IdCliente", cn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                        cmd.Parameters.AddWithValue("@CI", cliente.CI);
                        cmd.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                        cmd.Parameters.AddWithValue("@IdUsuario", cliente.IdUsuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con el Id proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        //Eliminar Cliente
        public void EliminarCliente(Clienteclass cliente)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTE WHERE IdCliente=@IdCliente", cn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }

    }
}
