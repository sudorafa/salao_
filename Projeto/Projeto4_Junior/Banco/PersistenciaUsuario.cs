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

namespace Projeto4_Junior.Banco
{
    class PersistenciaUsuario : IBancoDadosUsuario
    {
        public void CadastrarUsuario(Usuario usuario)
        {

        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            return null;
        }
        public void RemoverUsuario(Usuario usuario)
        {

        }

        public void AlterarUsuario(Usuario usuario)
        {

        }
        public bool Autenticar(String usuario, String senha)
        {
            bool retorno = false;
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
            
            return retorno;            
        }        
    }
}
