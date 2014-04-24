using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior
{
    interface IfachadaServico
    {
        void CadastrarServico(Servico servico);
        Servico BuscarServico(String Descricao);
        void RemoverServico(String Descricao);
        void AlterarServico(Servico servico);
        ArrayList ListarServico(String busca);
    }
}
