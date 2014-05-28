using Projeto4_Junior.Factory;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto4_Junior.Banco
{
    public class PersistenciaVenda : IBancoDadosVenda
    {


        public int CadastrarVenda(Modelo.Venda venda)
        {
            FactoryConnection conn = new FactoryConnection();
            int id = 0;
            string sSQL = @"INSERT INTO Venda
					(Valor, DataHoje, CPFFuncionario, CPFCliente) VALUES (@Valor, @DataHoje, @CPFFuncionario, @CPFCliente)
					SET @IdVenda = SCOPE_IDENTITY()";
            try
            {
                SqlCommand cmd = new SqlCommand(sSQL, conn.AbrirConnexao());
                cmd.Parameters.AddWithValue("@Valor", venda.ValorTotal);
                cmd.Parameters.AddWithValue("@DataHoje", DateTime.Now);
                cmd.Parameters.AddWithValue("@CPFFuncionario", venda.CPFFuncionario);
                cmd.Parameters.AddWithValue("@CPFCliente", venda.CPFCliente);
                cmd.Parameters.AddWithValue("@IdVenda", 0).Direction = System.Data.ParameterDirection.Output;


                cmd.ExecuteNonQuery();

                id = Convert.ToInt32(cmd.Parameters["@IdVenda"].Value);

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            finally
            {
                conn.FecharConnecxao();

            }
            return id;

        }
        public void CadastrarItensVenda(Modelo.ItensVenda item)
        {
            FactoryConnection conn = new FactoryConnection();
            String query = "";
            try
            {
                if (item.IdProduto == 0)
                {
                    query = "insert into VendaProdutoServico (IdVenda, IdServico) values" +
                     "('" + item.IdVenda + "', '" + item.IdServico + "')";
                }
                if (item.IdServico == 0)
                {
                    query = "insert into VendaProdutoServico (IdVenda,  IdProduto) values" +
                        "('" + item.IdVenda + "', '" + item.IdProduto + "')";
                }


                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            finally
            {
                conn.FecharConnecxao();
            }
        }
        public void RelatorioBalacoDiario()
        {
            FactoryConnection conn = new FactoryConnection();
            string endereco = "C:\relatorioBalancoDiario.csv";
            using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
            {
                writer.WriteLine("Descrição do Produto;"+
                                  "Entrada de Produto;"+
                                  "Saida de Produtro;"+
                                  "Valor Unitario do Produto;"+
                                  "Total Saida de Produto;"+
                                  "Descricao do Serviço;"+
                                  "Valor Unitário de Serviço;" +
                                  "Quantidade Total de Servico;"+
                                  "Total Saida de Servico;"+
                                  " Valor Total de Servico e Produto");

                SqlCommand sqlComand = new SqlCommand("RelatorioBalacoDiario", conn.AbrirConnexao());

                using (IDataReader reader = sqlComand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        writer.WriteLine( Convert.ToString(reader["Produto"]) + ";" +
                                          Convert.ToString(reader["EntradaProduto"]) + ";" +
                                          Convert.ToString(reader["SaidaProdutro"]) + ";" +
                                          Convert.ToString(reader["ValorUnitarioProduto"]) + ";" +
                                          Convert.ToString(reader["TotalSaidaProduto"]) + ";" +
                                          Convert.ToString(reader["Servico"]) + ";" +
                                          Convert.ToString(reader["ValorUnitarioServico"]) + ";" +
                                          Convert.ToString(reader["QuantidadeTotalServico"]) + ";" +
                                          Convert.ToString(reader["TotalSaidaServico"]) + ";" +
                                          Convert.ToString(reader["ValorTotalServicoProduto"]));
                    }
                }
                conn.FecharConnecxao();
            }
        }

        public Modelo.Venda BuscarVenda(int idVenda)
        {
            throw new NotImplementedException();
        }

        public void RemoverVenda(int idVenda)
        {
            throw new NotImplementedException();
        }

        public void AlterarVenda(Modelo.Venda venda)
        {
            throw new NotImplementedException();
        }

        public bool VerificaVenda(int idVenda)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ArrayList ListarVenda(int idVenda)
        {
            throw new NotImplementedException();
        }
    }
}
