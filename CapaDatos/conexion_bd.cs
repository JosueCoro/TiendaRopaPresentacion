using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexion_bd
    {
        public static string cn = "Data Source=LAPTOP-61IFHDPO\\SQLEXPRESS;Initial Catalog=BD_TIENDA_ROPA;Persist Security Info=True;User ID=sa;Password=13540503";



        public string GetCadenaConexion()
        {
            return cn;
        }
        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cn);
        }
    }
}
