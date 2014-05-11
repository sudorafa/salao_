using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosVenda
    {
        int CadastrarFuncionario(Venda venda);
        Venda BuscarFuncionario(int idVenda);
        void RemoverFuncionario(int idVenda);
        void AlterarFuncionario(Venda venda);
        bool VerificaFunc(int idVenda);
        ArrayList ListarFuncionario(int idVenda);
    }
}
