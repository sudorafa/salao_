using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosVenda
    {
        int CadastrarVenda(Venda venda);
        void CadastrarItensVenda(ItensVenda item);
        Venda BuscarVenda(int idVenda);
        void RemoverVenda(int idVenda);
        void AlterarVenda(Venda venda);
        bool VerificaVenda(int idVenda);
        ArrayList ListarVenda(int idVenda);
    }
}
