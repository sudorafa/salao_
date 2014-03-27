using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;

namespace Projeto4_Junior.Negocios
{
    class ControladorProduto : IfachadaProduto
    {
        private IBancoDadosProduto ibancodados = new BancoDadosProduto();
        public void CadastrarProdutos(Produto produto)
        {
            
        }
        public Produto BuscarProdutos(Produto produto)
        {
            return null;
        }
        public void RemoverProdutos(Produto produto)
        {
            
        }
        public void AlterarProdutos(Produto produto)
        {
          
        }
    }
}
