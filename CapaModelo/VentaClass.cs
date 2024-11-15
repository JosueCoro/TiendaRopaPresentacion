using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class VentaClass
    {
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<DetalleVenta> Detalles { get; set; }

        public class DetalleVenta
        {
            public int IdProducto { get; set; }
            public decimal PrecioVenta { get; set; }
            public int Cantidad { get; set; }
        }
    }
}
