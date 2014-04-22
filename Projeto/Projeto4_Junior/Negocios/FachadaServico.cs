using Projeto4_Junior.Modelo;
using System;
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
        public Servico BuscarServico(Servico servico)
        {
            return this.ifachada.BuscarServico(servico);
        }
        public void RemoverServico(Servico servico)
        {
            this.ifachada.RemoverServico(servico);
        }
        public void AlterarServico(Servico servico)
        {
            this.ifachada.AlterarServico(servico);
        }
    }
}
