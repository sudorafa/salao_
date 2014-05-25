using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaVenda : ifachadaVenda
    {
        public ifachadaVenda ifachada = new ControladorVenda();

        public int CadastrarVenda(Modelo.Venda venda)
        {
            return ifachada.CadastrarVenda(venda);
        }

        public Boolean CadastrarItensVenda(Modelo.ItensVenda item)
        {
            return ifachada.CadastrarItensVenda(item);
        }

        public Modelo.Venda BuscarVenda(int idVenda)
        {
            return ifachada.BuscarVenda(idVenda);
        }

        public void RemoverVenda(int idVenda)
        {
            ifachada.RemoverVenda(idVenda);
        }
        public void RemoverVendaItem(int idVenda)
        {
            ifachada.RemoverVendaItem(idVenda);
        }

        public void AlterarVenda(Modelo.Venda venda)
        {
            ifachada.AlterarVenda(venda);
        }

        public bool VerificaVenda(int idVenda)
        {
            return ifachada.VerificaVenda(idVenda);
        }

        public System.Collections.ArrayList ListarVenda(int idVenda)
        {
            return ifachada.ListarVenda(idVenda);
        }
    }
}
