using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosProduto
    {
        void CadastrarProdutos(Produto produto);
        Produto BuscarProdutos(Produto produto);
        void RemoverProdutos(Produto produto);
        void AlterarProdutos(Produto produto);
    }
}
