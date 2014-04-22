using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void RemoverServico(String servico)
        {           
            this.ibancodados.RemoverServico(servico);
        }
        public void AlterarServico(Servico servico)
        {           
            this.ibancodados.AlterarServico(servico);
        }
        public bool VerificaExistenciaServico(int IdServico)//----------foi acrescentado------------//
        {
            return this.ibancodados.VerificaExistenciaServico(IdServico);
        }
        public ArrayList ListarServico(String busca)
        {
            return this.ibancodados.ListarServico(busca);
        }
    }
}
