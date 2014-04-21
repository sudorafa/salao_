using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using System.Data.SqlClient;
using Projeto4_Junior.Factory;
using System.Windows.Forms;

namespace Projeto4_Junior.Banco
{
    class PersistenciaProduto : IBancoDadosProduto
    {
       
        
        public void CadastrarProdutos(Produto produto)
        {
            FactoryConnection conn = new FactoryConnection();

            try
            {

                String query = "insert into Produto (Descricao, Valor, Quantidade, Ativo) values" +
                "('" + produto.Descricao + "', '" + produto.Valor + "', '" + produto.Quantidade +
                "','" + produto.Ativo + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();       

                /*
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "INSERT INTO PRODUTO(DESCRICAO, VALOR, QUANTIDADE, Ativo)" +
                    "VALUES(@descricao, @valor, @quantidade_estoque)";
                comm.Parameters.AddWithValue("@descricao", produto.Descricao);
                comm.Parameters.AddWithValue("@valor", produto.Valor);
                comm.Parameters.AddWithValue("@quantidade_estoque", produto.Quantidade);
                comm.Parameters.AddWithValue("@Ativo", produto.Ativo);
                comm.Connection = fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
                 */

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco!");
            }
        }

        public Produto BuscarProdutos(Produto produto)
        {
            return null;
        }
        public void RemoverProdutos(Produto produto)
        {
            /*
            SqlCommand comm = new SqlCommand();
                comm.CommandText = "Insert into Produtos(excluido) values (1) where codigo=@codigo";
                comm.Parameters.AddWithValue("@codigo", produto.IdProduto);
                comm.Connection = fc.AbrirConnexao();
                comm.ExecuteNonQuery();
                fc.FecharConnecxao();
             */ 
        }
        public void AlterarProdutos(Produto produto)
        {

            /*
            try{
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update produtos set descricao=@descricao, valor=@valor, quantidade_estoque=@quantidade_estoque where codigo=@codigo";
            comm.Parameters.AddWithValue("@descricao", produto.Descricao);
            comm.Parameters.AddWithValue("@valor", produto.Valor);
            comm.Parameters.AddWithValue("@quantidade_estoque", produto.Quantidade);
            comm.Parameters.AddWithValue("@codigo", produto.IdProduto);
            comm.Connection = fc.AbrirConnexao();
            comm.ExecuteNonQuery();
            fc.FecharConnecxao();
            }catch(SqlException e)
            {
                MessageBox.Show("Não foi Possivel Conectar ao banco de dados!!!" + e);
            
            }
            */
        }
              
        public SqlDataReader VerificaProd(Produto produto)
        {
            return null;

            /*
            SqlCommand comm = new SqlCommand();
            SqlDataReader read = null;
            try
            {

                comm.CommandText = "select * from produtos where codigo=@codigo";
                comm.Parameters.AddWithValue("@codigo", produto.IdProduto);
                comm.Connection = fc.AbrirConnexao();
                read = comm.ExecuteReader();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Não foi Possivel Conectar ao banco de dados!!!" + e);
            }
            return read;
             */ 
        }
    }
}
