using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Entidad
{
    public class Compra
    {
        public List<Detalle_Compra> oDetalleCompra;

        public int IdCompra { get; set; }
        public Usuario objUsuario { get; set; }//Referencia a la clase Usuario
        public Proveedor objProveedor { get; set; }//Referencia a la clase Proveedor
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public List<Detalle_Compra> objListaDetalleCompra {  get; set; } //Es una referencia a la clase Detalle_Compra, es de tipo list porque en una compra se puede comprar varios productos
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }

    }
}
