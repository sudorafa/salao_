using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    public class BancoDadosVenda : IBancoDadosVenda
    {
        IBancoDadosVenda ibanco = new PersistenciaVenda();

        public int CadastrarVenda(Modelo.Venda venda)
        {
            return ibanco.CadastrarVenda(venda);
        }
        public void CadastrarItensVenda(Modelo.ItensVenda item)
        {
            ibanco.CadastrarItensVenda(item);
        }

        public Modelo.Venda BuscarVenda(int idVenda)
        {
            return ibanco.BuscarVenda(idVenda);
        }

        public void RemoverVenda(int idVenda)
        {
            ibanco.RemoverVenda(idVenda);
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
