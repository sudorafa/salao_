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
        SqlCommand comand = new SqlCommand();

        public SqlConnection AbrirConnexao()
        {
<<<<<<< HEAD
            conn.ConnectionString = @"Server=PROGRAMADOR-PC\SQLEXPRESS;Database=Projeto4;Trusted_Connection=True;";         
            //conn.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Projeto4;Trusted_Connection=True;";  
=======
            //conn.ConnectionString = @"Server=PROGRAMADOR-PC\SQLEXPRESS;Database=Projeto4;Trusted_Connection=True;";         
            conn.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=Projeto4;Trusted_Connection=True;";  
>>>>>>> 3775261f543ff22479e199cdc1f3015e1e0c79dc
            //conn.ConnectionString = "Server=localhost;Database=Projeto4;Trusted_Connection=True;";
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
                comand.Dispose();
                
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
