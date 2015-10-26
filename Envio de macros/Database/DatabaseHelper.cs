using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;


namespace Envio_de_macros.Persistencia
{
    /// <summary>
    /// Esta clase es utilizada como un helper para apoyar en la realización de operaciones
    /// CRUD además de la operación login
    /// </summary>
    class DatabaseHelper
    {
        /// <summary>
        /// Se utiliza para la inserción de un dato en la base de datos.
        /// Es static para que no necesite ser instanciado el objeto.
        /// </summary>
        /// <param name="sp">El procedure con el cual se realizará una inserción en la 
        /// base de datos.</param>
        public static void execSPCreate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdCreate = new SqlCommand(sp, conn);
                    cmdCreate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido añadido");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Se utiliza para una selección a la base de datos.
        /// Es static para que no necesite ser instanciado el objeto.
        /// </summary>
        /// <param name="sp">El sp con el cual se realizan las consultas.</param>
        /// <returns>Un objeto tipo Data Table con la información obtenida.
        /// Este objeto puede ser utilizado para llenar un Data Grid View o
        /// utilizado de otras formas.
        /// </returns>
        public static DataTable execSPRead(string sp)
        {
            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter;

            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdRead = new SqlCommand(sp, conn);
                    myDataAdapter = new SqlDataAdapter(cmdRead);
                    myDataAdapter.Fill(myDataTable);
                    conn.Close();
                    return myDataTable;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                    MessageBox.Show(ex.ToString());
                }
            }

            return myDataTable;
        }

        /// <summary>
        /// Se utiliza para la actualización de la base de datos.
        /// Es static para que no necesite ser instanciado el objeto.
        /// </summary>
        /// <param name="sp">El sp con el cual se realizan las actualizaciones.</param>
        public static void execSPUpdate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido modificado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Se utiliza para la eliminación de la base de datos.
        /// Es static para que no necesite ser instanciado el objeto.
        /// </summary>
        /// <param name="sp">El sp con el cual se realizan las eliminaciones de registros.</param>
        public static void execSPDelete(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("El elemento ha sido eliminado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Se utiliza para realizar un login en casi de haber una tabla de usuarios
        /// </summary>
        /// <param name="sp">Recibe el sp o consulta para realizar una autenticación 
        /// del usuario en la BD</param>
        /// <returns>Valor boolean. True si existe el ususario y las credenciales son correctas.
        /// False en caso contrario</returns>
        public static bool execSPLogin(string tabla, string usuario, string password)
        {
            string sp = "SELECT COUNT (*) FROM " + tabla + " WHERE usuario = '" + usuario + "' AND pass = '" + password + "'";
            bool login = false;
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdLogin = new SqlCommand(sp, conn);
                    SqlDataReader myReader = cmdLogin.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.GetValue(0).ToString().Equals("1"))
                        {
                            login = true;
                        }
                        break;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return login;
        }
    }
}
