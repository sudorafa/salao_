using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosCliente
    {
        void CadastrarCliente(Cliente cliente);
        Cliente BuscarCliente(String cpf);
        void RemoverCliente(String cliente);
        void AlterarCliente(Cliente cliente);
        bool VerificaExistenciaCliente(String cpf);
        ArrayList ListarCliente(String busca);
    }
}
