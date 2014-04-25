using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDadosProduto : IBancoDadosProduto
    {
        public IBancoDadosProduto ibancodados = new PersistenciaProduto();

        public void CadastrarProdutos(Produto produto)
        {            
            this.ibancodados.CadastrarProdutos(produto);
        }


        public Produto BuscarProdutos(Produto produto)
        {            
            return this.ibancodados.BuscarProdutos(produto);
        }


        public void RemoverProduto(String descricao)
        {            
            this.ibancodados.RemoverProduto(descricao);
        }


        public void AlterarProdutos(Produto produto)
        {            
            this.ibancodados.AlterarProdutos(produto);
        }


        public SqlDataReader VerificaProd(Produto produto)
        {
            return this.ibancodados.VerificaProd(produto);     
        
        }


        public ArrayList ListarProduto(String produto)
        {
            return this.ibancodados.ListarProduto(produto);
        }
    }
}
