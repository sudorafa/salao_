using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosFuncionario
    {
        void CadastrarFuncionario(Funcionario funionario);
        Funcionario BuscarFuncionario(Funcionario funionario);
        void RemoverFuncionario(Funcionario funionario);
        void AlterarFuncionario(Funcionario funionario);
    }
}
