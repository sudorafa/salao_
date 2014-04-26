using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Projeto4_Junior.Banco
{
    class BancoDadosServico : IBancoDadosServico
    {
        public IBancoDadosServico ibancodados = new PersistenciaServico(); 

        public void CadastrarServico(Servico servico)
        {            
            this.ibancodados.CadastrarServico(servico);
        }
        public Servico BuscarServico(String Descricao)
        {            
            return this.ibancodados.BuscarServico(Descricao);
        }
        public void RemoverServico(String Descricao)
        {           
            this.ibancodados.RemoverServico(Descricao);
        }
        public void AlterarServico(Servico servico, String idServicoParaServico)
        {           
            this.ibancodados.AlterarServico(servico, idServicoParaServico );
        }

        public bool VerificaExistenciaServico(String Descricao)//----------foi acrescentado------------//
        {
            return this.ibancodados.VerificaExistenciaServico(Descricao);
        }
        public ArrayList ListarServico(String busca)
        {
            return this.ibancodados.ListarServico(busca);
        }

    }
}
