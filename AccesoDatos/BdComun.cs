using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class BdComun
    {
        private readonly string conexion;
        public BdComun()
        {
            conexion = "Server = SHIHAN; DataBase = BD_CETAF; Integrated Security = True";
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(conexion);
        }
    }
}
