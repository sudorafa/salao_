using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaProduto
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
        public void RemoverProdutos(Produto produto)
        {
            this.ifachada.RemoverProdutos(produto);
        }
        public void AlterarProdutos(Produto produto)
        {
            this.ifachada.AlterarProdutos(produto);
        }
    }
}
