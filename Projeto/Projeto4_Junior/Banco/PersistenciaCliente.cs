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
using System.Windows.Forms;


namespace Projeto4_Junior.Banco
{
    class PersistenciaCliente : IBancoDadosCliente
    {
        public void CadastrarCliente(Cliente cliente)
        {            
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Cliente (Nome, CPF, Telefone, Endereco, DataDeNasc, Email) values" +
                "('" + cliente.Nome + "', '" + cliente.Cpf + "', '" + cliente.Telefone + "', '" + cliente.Endereco + "', '"
                + cliente.Data_Nascimento + "', '" + cliente.Email + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();                
                MessageBox.Show("Cadastrado Com sucesso!");
            }
            catch (Exception e)
            {
                
            }                  
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
                
            }
            
            return retorno;
            
        }
    }
}
