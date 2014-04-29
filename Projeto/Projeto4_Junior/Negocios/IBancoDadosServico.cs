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
        Servico BuscarServico(int idServico);
        void RemoverServico(String Descricao);
        void AlterarServico(Servico servico, String idServicoParaServico);
        bool VerificaExistenciaServico(String Descricao);//Foi acrescentado.
        ArrayList ListarServico(String busca);
         
    }
}
