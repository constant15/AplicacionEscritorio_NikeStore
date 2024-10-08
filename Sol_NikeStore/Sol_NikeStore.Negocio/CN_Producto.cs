using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Negocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario ingresar el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del Producto\n";
            }

           

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario ingresar el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del Producto\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }




        }

    }
}
