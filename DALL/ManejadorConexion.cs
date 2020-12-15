using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ManejadorConexion
    {
        public SqlConnection connection;

        public ManejadorConexion(string conexion)
        {
            connection = new SqlConnection(conexion);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
