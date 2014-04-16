using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using Projeto4_Junior.Factory;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Projeto4_Junior.Banco
{
    class PersistenciaUsuario : IBancoDadosUsuario
    {
        public void CadastrarUsuario(Usuario usuario)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Usuario (Nome, Login, Senha, isGestor) values" +
                "('" + usuario.Nome + "', '" + usuario.Login + "', '" + usuario.Senha +
                "', '" + usuario.isGestor + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                //comand.ExecuteNonQuery(); <---- Não seria melhor usar o comand pra executar a instrução SQL ?
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();                
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }          

        }
        public Usuario BuscarUsuario(String login)
        {
            return null;
        }
        public void RemoverUsuario(String login)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "DELETE FROM Usuario where Login ='" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Funcionário removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

        }

        public void AlterarUsuario(Usuario usuario)
        {

        }
        public bool Autenticar(String usuario, String senha)
        {
            bool retorno = false;
            try{                
                FactoryConnection conn = new FactoryConnection();   
                         
                    String query = "select Login, Senha from Usuario where Login='" + usuario + "' and Senha='" + senha + "'";                

                    SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                    SqlDataReader reader = comand.ExecuteReader();

                    if (reader.Read())
                    {
                        retorno = true;                    
                    }
                    else
                    {
                        retorno = false;
                    }
                
                conn.FecharConnecxao();  
            }
             catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }  
            
            return retorno;            
        }
        public bool VerificarUsuarioExistente(String login)
        {
            bool retorno = true;

            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "select Login from Usuario where Login ='" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                
                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
                conn.FecharConnecxao();
            }
           catch (Exception e)
           {
               MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
           }
            return retorno;
        }
        public bool VerificaTipoUsuario(String login)
        {
           bool retorno = true;
           try{
                FactoryConnection conn = new FactoryConnection();

                String query = "select isGestor from Usuario where Login='" + login + "' AND isGestor = '1'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
            

                if (reader.Read())
                {
                    conn.FecharConnecxao();
                    retorno = true;
                }
                else
                {
                    conn.FecharConnecxao();
                    retorno = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

           return retorno;
        }

        public ArrayList ListarUsuario(String busca)
        {
           FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Usuario WHERE nome LIKE '%"+busca+"%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Modelo.Usuario usu = new Modelo.Usuario();

                    usu.Nome = (String) reader["nome"];
                    usu.Login = (String)reader["login"];
                    usu.Senha = (String)reader["senha"];
                    usu.isGestor = (int)reader["TipoUsar"];
                   

                    lista.Add(usu);
                }
                reader.Close();                
                conn.FecharConnecxao();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return lista;
        }
    }
}

