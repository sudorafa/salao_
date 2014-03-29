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
            conn.ConnectionString = "Server=JEFFERSON-PC;Database=TESTE;Trusted_Connection=True;";
            SqlCommand comand = new SqlCommand();
            comand.Connection = conn;
            conn.Open();

            return conn;
        }      
        public void FecharConnecxao()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
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
    }
}
