using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaServico : IfachadaServico
    {
        public IfachadaServico ifachada = new ControladorServico();

        public void CadastrarServico(Servico servico)
        {
            this.ifachada.CadastrarServico(servico);
        }
        public Servico BuscarServico(String Descricao)
        {
            return this.ifachada.BuscarServico(Descricao);
        }
        public void RemoverServico(String Descricao)
        {
            this.ifachada.RemoverServico(Descricao);
        }
        public void AlterarServico(Servico servico)
        {
            this.ifachada.AlterarServico(servico);
        }
        public ArrayList ListarServico(String busca)
        {
            return this.ifachada.ListarServico(busca);
        }
    }
}
