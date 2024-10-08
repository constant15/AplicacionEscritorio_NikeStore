using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Sol_NikeStore.Datos
{
    //La clase conexion es la encargada de repartir una cadena de conexion a todas las demas clases 
    public class Conexion
    {
        //Almacena en "cadena" lo que tiene guardado en la variable cadena_conexion en app.config y ToString() lo convierte a texto
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString(); 
    }
}
