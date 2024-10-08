using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Entidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario objUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List <Detalle_Venta> objListaDetalleVenta { get; set; }
        public string FechaRegistro { get; set; }
    }
}
