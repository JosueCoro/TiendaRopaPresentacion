using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    internal class classAlmacen
    {
        public int IdAlmacen { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public char Estado { get; set; }
        public int Capacidad { get; set; }
    }
}
