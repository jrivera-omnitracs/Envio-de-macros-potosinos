using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Envio_de_macros.Properties;
using System.Windows.Forms;

namespace Envio_de_macros.Persistencia
{
    /// <summary>
    /// Administa las conexiones a la base de datos
    /// </summary>
    class Connection
    {
        /// <summary>
        /// Se genera una conexión a la base de datos
        /// </summary>
        /// <returns>Una conección a la base de datos</returns>
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.Potosinos3ConnectionString);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Ha ocurrido un error relacionado con la base de datos, "
                    + "por favor cierra la aplicación y vuelve a intentarlo"
                    + e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicación, "
                    + "por favor cierra la aplicación y vuelve a intentarlo"
                    + e.ToString());
            }
            return conn;
        }
    }
}
