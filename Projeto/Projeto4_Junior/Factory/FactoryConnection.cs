using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Projeto4_Junior.Factory
{
    class FactoryConnection
    {
        private static SqlConnection conn;
        public FactoryConnection()
        {
            conn = new SqlConnection("JUNIOR;Projeto4;Trusted_Connection=True;");
        }
        public static SqlConnection Conexao(SqlConnection conex)
        {
            if (conex == null)
            {
                new FactoryConnection();
                return conn;
            }
            return conex;
        }
    }
}
