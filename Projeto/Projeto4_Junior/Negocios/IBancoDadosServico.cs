using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosServico
    {
        void CadastrarServico(Servico servico);
        Servico BuscarServico(String Descricao);
        void RemoverServico(String Descricao);
        void AlterarServico(Servico servico);
        bool VerificaExistenciaServico(String Descricao);//Foi acrescentado.
        ArrayList ListarServico(String busca);
         
    }
}
