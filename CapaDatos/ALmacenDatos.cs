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
 
    public class ALmacenDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();
        public DataTable MostrarAlmacen()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from ALMACEN", cn))
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
        public DataTable ObtenerAlmacen()
        {
            using (SqlConnection cn = conexionbd.CrearConexion())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select IdAlmacen, Nombre FROM ALMACEN", cn))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtInsumos = new DataTable();
                    da.Fill(dtInsumos);
                    return dtInsumos;
                }
            }

        }


    }
}
