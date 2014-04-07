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
using System.Collections;


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
                //comand.ExecuteNonQuery(); <---- Não seria melhor usar o comand pra executar a instrução SQL ?
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();                
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }                  
        }
        public Cliente BuscarCliente(Cliente cliente)
        {
            return null;
        }
        public void RemoverCliente(String cpf)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "delete from Cliente where CPF ='" + cpf + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Cliente removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
        }
        public void AlterarCliente(Cliente cliente)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "update Cliente set Nome = '"+cliente.Nome+"', telefone = '"+cliente.Telefone+"', endereco = '"
                +cliente.Endereco+"', DataDeNasc = '"+cliente.Data_Nascimento+"', email = '"+cliente.Email+"' where cpf = '"+cliente.Cpf+"'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());              
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }             
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
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return retorno;
        }
        public ArrayList ListarCliente(String busca)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Cliente WHERE nome LIKE '%"+busca+"%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cli = new Cliente();

                    cli.Nome = (String) reader["nome"];
                    cli.Cpf = (String)reader["cpf"];
                    cli.Data_Nascimento = (String)reader["dataDeNasc"];
                    cli.Email = (String)reader["email"];
                    cli.Endereco = (String)reader["endereco"];
                    cli.Telefone = (String)reader["telefone"];

                    lista.Add(cli);
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
