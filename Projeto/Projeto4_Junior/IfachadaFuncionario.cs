using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior
{
    interface IfachadaFuncionario
    {
        void CadastrarFuncionario(Funcionario funionario);
        Funcionario BuscarFuncionario(String cpf);
        void RemoverFuncionario(String cpf);
        void AlterarFuncionario(Funcionario funionario);
        SqlDataReader VerificaFunc(Funcionario funcionario);
        ArrayList ListarFuncionario(String buscar);
    }
}
