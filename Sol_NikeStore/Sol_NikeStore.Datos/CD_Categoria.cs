using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_NikeStore.Datos
{
    public class CD_Categoria
    {
      //Metodo para listar todos los Categorias almacenados en la base de datos 
            public List<Categoria> Listar()
            {
                List<Categoria> lista = new List<Categoria>();

                //Aqui nos conectamos a la base de datos, yendo a la clase Conexion y tomando lo que esta almacenado en la variable cadena
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("select IdCategoria, Descripcion, Estado from Categoria");
                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.CommandType = CommandType.Text;
                        oconexion.Open(); //Abre la conexion a la base de datos 

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {     //Con este comando lee las tablas de la base de datos 

                            while (dr.Read())
                            {
                                lista.Add(new Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Estado = Convert.ToBoolean(dr["Estado"]),
                                 });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //Si hay un error, que liste un Categoria vacio
                        lista = new List<Categoria>();
                    }
                }

                return lista;




            }

            //Metodo que se conecta a la base de datos y registra un Categoria en ella desde la interfaz del programa
            public int Registrar(Categoria obj, out string Mensaje)
            {
                int idCategoriagenerado = 0;
                Mensaje = string.Empty;

                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("sp_registrarCategoria", oconexion);
                        cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                        cmd.Parameters.AddWithValue("Estado", obj.Estado);
                        cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();

                        cmd.ExecuteNonQuery();

                        idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                        Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    }
                }
                catch (Exception ex)
                {
                    idCategoriagenerado = 0;
                    Mensaje = ex.Message;
                }

                return idCategoriagenerado;
            }

            //Metodo que se conecta a la base de datos y edita un Categoria en ella desde la interfaz del programa
            public bool Editar(Categoria obj, out string Mensaje)
            {
                bool respuesta = false;
                Mensaje = string.Empty;

                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("sp_EditarCategoria", oconexion);
                        cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                        cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                        cmd.Parameters.AddWithValue("Estado", obj.Estado);
                        cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();

                        cmd.ExecuteNonQuery();

                        respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    }
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }

                return respuesta;
            } 
    }
}
