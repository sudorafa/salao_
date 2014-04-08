using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosFuncionario
    {
        void CadastrarFuncionario(Funcionario funionario);
        Funcionario BuscarFuncionario(String cpf);
        void RemoverFuncionario(String cpf);
        void AlterarFuncionario(Funcionario funionario);
        SqlDataReader VerificaFunc(Funcionario funcionario);
        ArrayList ListarFuncionario(String buscar);
    }
}
