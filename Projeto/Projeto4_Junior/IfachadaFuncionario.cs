using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior
{
    interface IfachadaFuncionario
    {
        void CadastrarFuncionario(Funcionario funionario);
        Funcionario BuscarFuncionario(Funcionario funionario);
        void RemoverFuncionario(Funcionario funionario);
        void AlterarFuncionario(Funcionario funionario);
        SqlDataReader VerificaFunc(Funcionario funcionario);
    }
}
