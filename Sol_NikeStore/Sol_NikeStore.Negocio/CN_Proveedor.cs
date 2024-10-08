using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Negocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el numero de documento del Proveedor.\n";
            }

            if (obj.RazonSocial== "")
            {
                Mensaje += "Es necesario ingresar razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario ingresar el telefono de contacto del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el numero de documento del Proveedor.\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario ingresar razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario ingresar el telefono de contacto del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }




        }
    }
}

