using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CI { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
    public class UsuarioLogin
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
