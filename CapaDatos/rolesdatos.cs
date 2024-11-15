using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class rolesdatos
    {
        private string conexionbd = new conexion_bd().GetCadenaConexion();
        private conexion_bd conexion = new conexion_bd();

        public DataTable ObtenerRoles()
        {
            using (SqlConnection cn = conexion.CrearConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select IdRol, Nombre_Rol FROM ROL", cn);  // Obtenemos ID_Rol y Nombre_Rol
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtRoles = new DataTable();
                da.Fill(dtRoles);
                return dtRoles;
            }
        }
        public DataTable MostrarRoles()
        {
            using (SqlConnection cn = conexion.CrearConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * FROM ROL", cn);  // Obtenemos ID_Rol y Nombre_Rol
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtRoles = new DataTable();
                da.Fill(dtRoles);
                return dtRoles;
            }
        }
        //CREAR ROLES(Nombre_Rol y Descripcion)
        public void CrearRoles(string Nombre_Rol, string Descripcion)
        {
            using (SqlConnection cn = conexion.CrearConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ROL(Nombre_Rol, Descripcion) VALUES(@Nombre_Rol, @Descripcion)", cn);
                cmd.Parameters.AddWithValue("@Nombre_Rol", Nombre_Rol);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.ExecuteNonQuery();
            }
        }
        //actualizar roles
        public void ActualizarRoles(int IdRol, string Nombre_Rol, string Descripcion)
        {
            using (SqlConnection cn = conexion.CrearConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ROL SET Nombre_Rol = @Nombre_Rol, Descripcion = @Descripcion WHERE IdRol = @IdRol", cn);
                cmd.Parameters.AddWithValue("@IdRol", IdRol);
                cmd.Parameters.AddWithValue("@Nombre_Rol", Nombre_Rol);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.ExecuteNonQuery();
            }
        }
        //eliminar roles
        public void EliminarRoles(int IdRol)
        {
            using (SqlConnection cn = conexion.CrearConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ROL WHERE IdRol = @IdRol", cn);
                cmd.Parameters.AddWithValue("@IdRol", IdRol);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
