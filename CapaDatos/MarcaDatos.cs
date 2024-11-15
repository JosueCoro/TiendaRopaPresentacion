using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class MarcaDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        //mostrar marca
        public DataTable MostrarMarca2()
        {
            DataTable dtMarca = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from MARCA", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dtMarca.Load(dr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al mostrar las marcas: " + ex.Message);
            }

            return dtMarca;
        }
        public DataTable MostrarMarca()
        {
            DataTable dtMarca = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select IdMarca, NombreMarca from MARCA\r\n", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dtMarca.Load(dr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar las marcas: " + ex.Message);
            }

            return dtMarca;
        }
    }
}
