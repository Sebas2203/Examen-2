using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace reparacionweb.classes
{
    public class Equipos
    {
        public int id { get; set; }
        public int idUsuarios { get; set; }
        public string tipoEquipo { get; set; }
        public string modelo { get; set; }

        public Equipos(int id, int idUsuarios, string tipoEquipo, string modelo)
        {
            this.id = id;
            this.idUsuarios = idUsuarios;
            this.tipoEquipo = tipoEquipo;
            this.modelo = modelo;
        }

        public Equipos()
        {
        }

        public static int Agregar(int idUsuarios, string tipoEquipo, string modelo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("agregarEquipo", Conn)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@idUsuarios", idUsuarios));
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;

            }
            finally { Conn.Close(); }

            return retorno;
        }

        public static int Borrar(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borrarEquipo", Conn)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;

            }
            finally { Conn.Close(); }

            return retorno;
        }

        public static int Modificar(int id, int idUsuario, string tipoEquipo, string modelo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("modificarEquipo", Conn)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;

            }
            finally { Conn.Close(); }

            return retorno;
        }

        public static int Consultar(int id)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultarEquipo", Conn)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string nombre = reader["nombre"].ToString();
                            }

                            retorno = 1;
                        }
                        else
                        {
                            retorno = 0;
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}