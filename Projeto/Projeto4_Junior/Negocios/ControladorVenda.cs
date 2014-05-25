using Projeto4_Junior.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto4_Junior.Negocios
{
    class ControladorVenda : ifachadaVenda
    {
        public IBancoDadosVenda ibanco = new BancoDadosVenda();
        public int CadastrarVenda(Modelo.Venda venda)
        {
            return ibanco.CadastrarVenda(venda);
        }
        public Boolean CadastrarItensVenda(Modelo.ItensVenda item)
        {
            return ibanco.CadastrarItensVenda(item);
        }

        public Modelo.Venda BuscarVenda(int idVenda)
        {
            return ibanco.BuscarVenda(idVenda);
        }

        public void RemoverVenda(int idVenda)
        {
            ibanco.RemoverVenda(idVenda);
        }
        public void RemoverVendaItem(int idVenda)
        {
            ibanco.RemoverVendaItem(idVenda);
        }

        public void AlterarVenda(Modelo.Venda venda)
        {
            ibanco.AlterarVenda(venda);
        }

        public bool VerificaVenda(int idVenda)
        {
            return ibanco.VerificaVenda(idVenda);
        }

        public System.Collections.ArrayList ListarVenda(int idVenda)
        {
            return ibanco.ListarVenda(idVenda);
        }
    }
}
