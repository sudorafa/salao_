using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaProduto : IfachadaProduto
    {
        public IfachadaProduto ifachada = new ControladorProduto();
        public void CadastrarProdutos(Produto produto)
        {
            this.ifachada.CadastrarProdutos(produto);
        }
        public Produto BuscarProdutos(Produto produto)
        {
            return this.ifachada.BuscarProdutos(produto);
        }
        public void RemoverProduto(String descricao)
        {
            this.ifachada.RemoverProduto(descricao);
        }
        public void AlterarProdutos(Produto produto)
        {
            this.ifachada.AlterarProdutos(produto);
        }
        public SqlDataReader VerificaProd(Produto produto)
        {
           return this.ifachada.VerificaProd(produto);
        }

        public ArrayList ListarProduto(String produto)
        {
            return this.ifachada.ListarProduto(produto);
        }


    }
}
