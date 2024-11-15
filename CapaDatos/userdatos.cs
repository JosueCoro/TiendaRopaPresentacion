using CapaModelo;
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
    public class userdatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        //LOGIN validar usuario
        public UsuarioLogin ValidarUsuario(string correo, string contraseña)
        {
            UsuarioLogin usuario = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Correo, Contraseña FROM USUARIO WHERE Correo = @Correo AND Contraseña = @Contraseña", cn))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                usuario = new UsuarioLogin
                                {
                                    Correo = dr["Correo"].ToString(),
                                    Contraseña = dr["Contraseña"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
            }

            return usuario;
        }
        //mostrar usuarios
        public DataTable MostrarUser()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * from USUARIO", cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dtUsuarios);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }

            return dtUsuarios;
        }
        //CREAR USUARIO
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"
                INSERT INTO USUARIO (CI, NombreCompleto, Correo, Contraseña, IdRol, Estado, FechaRegistro)
                VALUES (@CI, @NombreCompleto, @Correo, @Contraseña, @IdRol, @Estado, GETDATE())", cn))
                    {
                        // Parámetros del comando SQL
                        cmd.Parameters.AddWithValue("@CI", usuario.CI);
                        cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña); // Aquí la contraseña es texto plano
                        cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@Estado", usuario.Estado);

                        // Ejecutar el comando
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario creado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"
                UPDATE USUARIO
                SET CI = @CI,
                    NombreCompleto = @NombreCompleto,
                    Correo = @Correo,
                    Contraseña = @Contraseña,
                    IdRol = @IdRol,
                    Estado = @Estado
                WHERE IdUsuario = @IdUsuario", cn))
                    {
                        // Parámetros del comando SQL
                        cmd.Parameters.AddWithValue("@CI", usuario.CI);
                        cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña); // Aquí la contraseña es texto plano
                        cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                        cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario); // ID del usuario a actualizar

                        // Ejecutar el comando
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario actualizado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario", cn))
                    {
                        // Parámetro del comando SQL
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        // Ejecutar el comando
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

    }
}
