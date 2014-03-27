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
    class ControladorServico : IfachadaServico
    {
        private IBancoDadosServico ibancodados = new BancoDadosServico();
           
        public void CadastrarServico(Servico servico)
        {
            
        }
        public Servico BuscarServico(Servico servico)
        {
            return null;
        }
        public void RemoverServico(Servico servico)
        {
            
        }
        public void AlterarServico(Servico servico)
        {
            
        }
    }
}
