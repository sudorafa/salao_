using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
<<<<<<< HEAD
using System.Collections;
=======
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDadosServico : IBancoDadosServico
    {
        public IBancoDadosServico ibancodados = new PersistenciaServico(); 
<<<<<<< HEAD

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
=======

        public void CadastrarServico(Servico servico)
        {            
            this.ibancodados.CadastrarServico(servico);
        }
        public Servico BuscarServico(Servico servico)
        {            
            return this.ibancodados.BuscarServico(servico);
        }
        public void RemoverServico(Servico servico)
        {           
            this.ibancodados.RemoverServico(servico);
        }
        public void AlterarServico(Servico servico)
        {           
            this.ibancodados.AlterarServico(servico);
        }

>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
        public bool VerificaExistenciaServico(int IdServico)//----------foi acrescentado------------//
        {
            return this.ibancodados.VerificaExistenciaServico(IdServico);
        }
<<<<<<< HEAD
        public ArrayList ListarServico(String busca)
        {
            return this.ibancodados.ListarServico(busca);
        }
=======
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
    }
}
