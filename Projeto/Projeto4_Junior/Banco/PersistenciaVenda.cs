using Projeto4_Junior.Factory;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string sSQL = @"INSERT INTO venda
					(ValorTotal, Data, CPFFuncionario, CPFCliente) VALUES (@valorTotal, @data, @cpfFuncionario, @cpfCliente)
					SET @idVenda = SCOPE_IDENTITY()";
                try { 
                    SqlCommand cmd = new SqlCommand(sSQL, conn.AbrirConnexao());
                    cmd.Parameters.AddWithValue("@valorTotal", venda.ValorTotal);
                    cmd.Parameters.AddWithValue("@data", venda.Data);
                    cmd.Parameters.AddWithValue("@cpfFuncionario", venda.CPFFuncionario);
                    cmd.Parameters.AddWithValue("@cpfCliente", venda.CPFCliente);
                    cmd.Parameters.AddWithValue("@idVenda", 0).Direction = System.Data.ParameterDirection.Output;

                
                    cmd.ExecuteNonQuery();

                    id = Convert.ToInt32(cmd.Parameters["@idVenda"].Value);

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
        public Boolean CadastrarItensVenda(Modelo.ItensVenda item)
        {
            FactoryConnection conn = new FactoryConnection();
            String query = "";
            try
            {
                if(item.IdProduto == 0)
                {
                    query = "insert into VendaProdutoServico (idVenda, idServico) values" +
                     "('" + item.IdVenda + "', '" + item.IdServico  + "')";
                }
                if (item.IdServico == 0)
                {
                    query = "insert into VendaProdutoServico (idVenda,  idProduto) values" +
                        "('" + item.IdVenda + "', '"  + item.IdProduto + "')";
                }
                

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();

                return true;
                
            }
            catch (Exception e)
            {
                
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
                return false;
            }
            finally
            {
                conn.FecharConnecxao();
            }
        }

        public Modelo.Venda BuscarVenda(int idVenda)
        {
            throw new NotImplementedException();
        }

        public void RemoverVenda(int idVenda)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "DELETE FROM venda WHERE idVenda='"+idVenda+"'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conn.FecharConnecxao();
            }
        }
        public void RemoverVendaItem(int idVenda)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "DELETE FROM VendaProdutoServico WHERE idVenda='" + idVenda + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.FecharConnecxao();
            }
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
