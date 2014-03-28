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
    public class FactoryConnection
    {
        private static SqlConnection conn = new SqlConnection();
        
        public SqlConnection AbrirConnexao()
        {
            conn.ConnectionString = "Server=JUNIOR;Database=Projeto4;Trusted_Connection=True;";
            conn.Open();

            return conn;
        }      
        public void FecharConnecxao(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
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

        internal void FecharConnecxao(FactoryConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
