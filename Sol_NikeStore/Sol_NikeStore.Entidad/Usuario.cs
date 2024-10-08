﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Entidad
{
    public class Usuario
    {
        public int IdUsuario{ get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol ObjRol { get; set; }
        public bool  Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
