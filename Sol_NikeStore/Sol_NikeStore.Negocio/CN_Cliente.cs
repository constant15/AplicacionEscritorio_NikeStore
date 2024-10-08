using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Negocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el numero de documento del cliente.\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del cliente\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario ingresar el apellido del cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario ingresar el telefono de contacto del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el numero de documento del cliente.\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del cliente\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario ingresar el apellido del cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario ingresar el telefono de contacto del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }




        }
    }
}
