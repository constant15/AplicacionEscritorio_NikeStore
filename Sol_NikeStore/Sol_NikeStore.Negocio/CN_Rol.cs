using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Negocio
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();

        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
