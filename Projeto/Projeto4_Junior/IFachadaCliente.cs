using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto4_Junior
{
    interface IFachadaCliente
    {
        void CadastrarCliente(Cliente cliente);
        Cliente BuscarCliente(Cliente cliente);
        void RemoverCliente(Cliente cliente);
        void AlterarCliente(Cliente cliente);
       
    }
}
