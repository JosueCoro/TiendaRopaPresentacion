using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ProductoClass
    {
        public int IdProducto {  get; set; }
        public string Nombre {set; get; }
        public string Descripcion {set; get; }
        public int IdCategoria { set; get; }
        public int IdMarca {  set; get; }
        public int Stock { set; get; }
        public float PrecioCompra { set; get; }
        public float PrecioVenta { set; get; }
        public string Estado {  set; get; }
        public DateTime FechaRegistro {  set; get; }
    }
}
