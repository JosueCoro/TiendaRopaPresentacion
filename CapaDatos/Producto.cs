using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaDatos
{
    public class Producto
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();
        public DataTable MostrarProducto()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from PRODUCTO", cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dtUsuarios);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los productos: " + ex.Message);
            }

            return dtUsuarios;
        }
        public DataTable ObtenerProducto()
        {
            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select IdProducto, Nombre FROM PRODUCTO", cn))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtInsumos = new DataTable();
                    da.Fill(dtInsumos);
                    return dtInsumos;
                }
            }
        }

        public string ObtenerNombrePorId(int idproducto)
        {
            string nombre = string.Empty;

            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Nombre FROM PRODUCTO WHERE IdProducto = @IdProducto", cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idproducto);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nombre = result.ToString();
                    }
                }
            }

            return nombre;
        }
        public decimal ObtenerPrecioPorId(int idproducto)
        {
            decimal precio = 0;

            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT PrecioVenta, PrecioCompra FROM PRODUCTO WHERE IdProducto = @IdProducto", cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idproducto);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        precio = Convert.ToDecimal(result);
                    }
                }
            }

            return precio;
        }
        /* CREATE TABLE PRODUCTO (
            IdProducto INT PRIMARY KEY IDENTITY (1, 1),
            Nombre VARCHAR(150),
            Descripcion VARCHAR(50),
            IdCategoria INT REFERENCES CATEGORIA(IdCategoria),
            IdMarca INT REFERENCES MARCA(IdMarca),
            Stock INT NOT NULL DEFAULT 0,
            PrecioCompra DECIMAL(10, 2) DEFAULT 0,
            PrecioVenta DECIMAL(10, 2) DEFAULT 0,
            Estado CHAR(1),
            FechaRegistro DATETIME DEFAULT GETDATE()
        ); */
        //Crear un nuevo producto
        public bool CrearProducto(ProductoClass producto)
        {
            bool exito = false;

            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO (Nombre, Descripcion, IdCategoria, IdMarca, Stock, PrecioCompra, PrecioVenta, Estado) VALUES (@Nombre, @Descripcion, @IdCategoria, @IdMarca, @Stock, @PrecioCompra, @PrecioVenta, @Estado)", cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdMarca", producto.IdMarca);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);

                    exito = cmd.ExecuteNonQuery() > 0;
                }
            }

            return exito;
        }
        //Actualizar un producto
        public bool ActualizarProducto(ProductoClass producto)
        {
            bool exito = false;

            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE PRODUCTO SET Nombre = @Nombre, Descripcion = @Descripcion, IdCategoria = @IdCategoria, IdMarca = @IdMarca, Stock = @Stock, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, Estado = @Estado WHERE IdProducto = @IdProducto", cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdMarca", producto.IdMarca);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);

                    exito = cmd.ExecuteNonQuery() > 0;
                }
            }

            return exito;
        }
        //Eliminar un producto
        public bool EliminarProducto(int idproducto)
        {
            bool exito = false;

            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto", cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idproducto);

                    exito = cmd.ExecuteNonQuery() > 0;
                }
            }

            return exito;
        }

        
    }
}
