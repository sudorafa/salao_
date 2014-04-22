using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosServico
    {
        void CadastrarServico(Servico servico);
        Servico BuscarServico(String Descricao);
        void RemoverServico(String Descricao);
        void AlterarServico(Servico servico);
        bool VerificaExistenciaServico(int IdServico);//Foi acrescentado.
<<<<<<< HEAD
        ArrayList ListarServico(String busca);
=======
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
         
    }
}
