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

        public int CadastrarFuncionario(Modelo.Venda venda)
        {
            return ifachada.CadastrarFuncionario(venda);
        }

        public Modelo.Venda BuscarFuncionario(int idVenda)
        {
            return ifachada.BuscarFuncionario(idVenda);
        }

        public void RemoverFuncionario(int idVenda)
        {
            ifachada.RemoverFuncionario(idVenda);
        }

        public void AlterarFuncionario(Modelo.Venda venda)
        {
            ifachada.AlterarFuncionario(venda);
        }

        public bool VerificaFunc(int idVenda)
        {
            return ifachada.VerificaFunc(idVenda);
        }

        public System.Collections.ArrayList ListarFuncionario(int idVenda)
        {
            return ifachada.ListarFuncionario(idVenda);
        }
    }
}
