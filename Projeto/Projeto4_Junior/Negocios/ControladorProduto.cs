using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Projeto4_Junior.Negocios
{
    class ControladorProduto : IfachadaProduto
    {
        private IBancoDadosProduto ibancodados = new BancoDadosProduto();
        public void CadastrarProdutos(Produto produto)
        {           
            this.ibancodados.CadastrarProdutos(produto);           
        }
        public Produto BuscarProduto(int idProduto)
        {
            return this.ibancodados.BuscarProduto(idProduto);
        }
        public void RemoverProduto(String descricao)
        {
            this.ibancodados.RemoverProduto(descricao);
        }
        public void AlterarProduto(Produto produto)
        {
            this.ibancodados.AlterarProduto(produto);
        }
        /*
        public SqlDataReader VerificaProd(Produto produto)
        {
            return this.ibancodados.VerificaProd(produto);  
        }
        */
        public ArrayList ListarProduto(String produto)
        {
            return this.ibancodados.ListarProduto(produto);
        }
    }
}
