using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto4_Junior.Negocios
{
    class FachadaCliente : IFachadaCliente
    {
        public IFachadaCliente ifachada = new ControladorCliente();        

        public void CadastrarCliente(Cliente cliente)
        {
            this.ifachada.CadastrarCliente(cliente);
        }
        public Cliente BuscarCliente(Cliente cliente)
        {
           return this.ifachada.BuscarCliente(cliente);
        }
        public void RemoverCliente(Cliente cliente)
        {
            this.ifachada.RemoverCliente(cliente);
        }
        public void AlterarCliente(Cliente cliente)
        {
            this.ifachada.AlterarCliente(cliente);
        }
        
    }
}
