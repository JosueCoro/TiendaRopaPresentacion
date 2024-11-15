using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class categoriaDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        public DataTable MostrarCategoria()
        {
            DataTable dtCategoria = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIA", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dtCategoria.Load(dr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las categorias: " + ex.Message);
            }

            return dtCategoria;
        }
    }
}
