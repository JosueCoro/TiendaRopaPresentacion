using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class InventarioDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();
        public DataTable MostrarInventario()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from INVENTARIO", cn))
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
    }
}
