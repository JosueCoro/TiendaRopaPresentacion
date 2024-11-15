using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    
    public class classInentario
    {
        public int idProveedor { get; set; }
        public string NombreCompleto { get; set; }
        public string NIT { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
