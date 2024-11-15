using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class CompraClass
    {
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Decimal MontoTotal { get; set; }
        public DateTime FechaRegistro {  get; set; }


        public List<DetalleCompra> Detalles { get; set; }
        public CompraClass()
        {
            Detalles = new List<DetalleCompra>();
        }
        public class DetalleCompra
        {
            public int IdProducto { get; set; }
            public Decimal PrecioCompra { set; get; }
            public Decimal PrecioVenta { set; get; }
            public int Cantidad { get; set; }
            public DateTime FechaRegistro { get; set; }
        }

        public class RealizarCompras
        {
            public int IdCompra { get; set; }
            public DataTable Productos { get; set; }
        }
    }
}
