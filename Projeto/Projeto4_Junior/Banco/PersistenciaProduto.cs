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
using System.Collections;

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

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco!");
            }
        }

        public Produto BuscarProduto(String descricao)
        {
            FactoryConnection conn = new FactoryConnection();
            Produto prod = new Produto();
            try
            {
                String query = "SELECT * FROM Produto WHERE login = '" + descricao + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    prod.Descricao = (String)reader["Descricao"];
                    prod.Valor = (Decimal)reader["Valor"];
                    prod.Quantidade = (int)reader["Quantidade"];
                    prod.IdProduto = (int)reader["IdProduto"];
                    
                }
                reader.Close();
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }

            return prod;
            
        }
        public void RemoverProduto(String descricao)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Produto SET Ativo=0 WHERE Descricao = '" + descricao + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();
                MessageBox.Show("Produto removido com sucesso!");
                conn.FecharConnecxao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados!");
            }
            
        }
        public void AlterarProduto(Produto produto)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "UPDATE Produto SET Descricao = '" + produto.Descricao +
                    "', Valor = '" + produto.Valor +
                    "', Quantidade = '" + produto.Quantidade +
                    "' WHERE IdProduto = '" + produto.IdProduto + "'";

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
        
        public ArrayList ListarProduto(String produto)
        {
            FactoryConnection conn = new FactoryConnection();
            ArrayList lista = new ArrayList();

            try
            {
                String query = "SELECT * FROM Produto WHERE Descricao LIKE '%" + produto + "%'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Produto umProduto = new Produto();

                    umProduto.Descricao = (String)reader["Descricao"];
                    umProduto.Valor = (Decimal)reader["Valor"];
                    umProduto.Quantidade = (int)reader["Quantidade"];                    
                    umProduto.Ativo = (Boolean)reader["Ativo"];

                    if (umProduto.Ativo == true)
                    {
                        lista.Add(umProduto);
                    }
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
