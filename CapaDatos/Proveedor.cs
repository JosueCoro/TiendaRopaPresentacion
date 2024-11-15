using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Proveedor
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();
        public DataTable MostrarProveedor()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from PROVEEDOR", cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dtUsuarios);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los proveedor: " + ex.Message);
            }

            return dtUsuarios;
        }
        public DataTable ObtenerProveedor()
        {
            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select IdProveedor, NombreCompleto FROM PROVEEDOR", cn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtInsumos = new DataTable();
                    da.Fill(dtInsumos);
                    return dtInsumos;
                }
            }
        }
    }
}
