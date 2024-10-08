using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;


namespace Sol_NikeStore.Negocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_negocio = new CD_Negocio();

        public NegocioBis ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }

        public bool GuardarDatos(NegocioBis obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreNegocio == "")
            {
                Mensaje += "Es necesario ingresar el nombre del negocio\n";
            }

            if (obj.Rut == "")
            {
                Mensaje += "Es necesario ingresar el numero de RUT\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario ingresar la direccion\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_negocio.ActualizarLogo(imagen, out mensaje);
        }

    }
}
