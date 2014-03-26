using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosServico
    {
        void CadastrarServico(Servico servico);
        Servico BuscarServico(Servico servico);
        void RemoverServico(Servico servico);
        void AlterarServico(Servico servico);

    }
}
