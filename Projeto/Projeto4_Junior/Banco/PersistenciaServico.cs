using Projeto4_Junior.Modelo;
using Projeto4_Junior.Factory;//-----foi acrescentado-------//
using Projeto4_Junior;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient; //---------foi acrescentado-----//
using System.Windows.Forms;  //-------foi acrescentado-------//


namespace Projeto4_Junior.Banco
{
    class PersistenciaServico : IBancoDadosServico
    {
        public void CadastrarServico(Servico servico) //--------foi acrescentado---------//
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Servico(Descricao,Valor,Ativo) values" +
                "('" + servico.Descricao + "', '" + servico.Valor + "', '" + servico.Ativo + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                //comand.ExecuteNonQuery(); <---- Não seria melhor usar o comand pra executar a instrução SQL ?
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");//----até aqui----/
            }   

        }
        public Servico BuscarServico(String Descricao)
        {
            FactoryConnection conn = new FactoryConnection();
            Servico servico = new Servico();
            try
            {
                String query = "SELECT * FROM Servico WHERE login = '" + Descricao + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    servico.Descricao = (String)reader["Descricao"];
                    servico.Valor = (Decimal)reader["Valor"];
                    servico.Ativo = (Boolean)reader["Ativo"];
                }
                reader.Close();
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return servico;

        }
        public void RemoverServico(String Descricao)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Servico SET Ativo=0 WHERE Descricao = '" + Descricao + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Serviço removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

        }
        public void AlterarServico(Servico servico)
        {

        }
        public bool VerificaExistenciaServico(int IdServico)
        {
            return false;

        }//Foi acrescentado.
        public ArrayList ListarServico(String busca)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();
            try
            {
                String query = "SELECT * FROM Servico WHERE nome LIKE '%"+busca+"%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                     Servico servico = new Servico();
                     servico.Descricao = (String)reader["Descricao"];
                     servico.Valor = (Decimal)reader["Valor"];
                     servico.Ativo = (Boolean)reader["Ativo"];
                                        
                    if (servico.Ativo == true)
                    {
                        lista.Add(servico);
                    }
                }
                reader.Close();
                conn.FecharConnecxao();

            }
            catch (SqlException e)
            {
                e.Message.GetType();
            }

            return lista;
        }
    
    }
}
