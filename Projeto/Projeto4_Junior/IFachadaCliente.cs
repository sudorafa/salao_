using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace Projeto4_Junior
{
    interface IFachadaCliente
    {
        void CadastrarCliente(Cliente cliente);
        Cliente BuscarCliente(String cpf);
        void RemoverCliente(String cpf);
        void AlterarCliente(Cliente cliente);
        ArrayList ListarCliente(String busca);
    }
}
