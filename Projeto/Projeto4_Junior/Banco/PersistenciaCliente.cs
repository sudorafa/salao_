using Projeto4_Junior.Modelo;
using Projeto4_Junior.Factory;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient;


namespace Projeto4_Junior.Banco
{
    class PersistenciaCliente : IBancoDadosCliente
    {
        public void CadastrarCliente(Cliente cliente)
        {

        }
        public Cliente BuscarCliente(Cliente cliente)
        {
            return null;
        }
        public void RemoverCliente(Cliente cliente)
        {

        }
        public void AlterarCliente(Cliente cliente)
        {

        }

        public bool VerificaExistenciaCliente(String cpf)
        {
            bool retorno = true;
            FactoryConnection conn = new FactoryConnection();
            try
            {               
                String query = "select CPF from Cliente where CPF ='" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.NextResult())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }                
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conn.FecharConnecxao(conn);
            }
            
            return retorno;
            
        }
    }
}
