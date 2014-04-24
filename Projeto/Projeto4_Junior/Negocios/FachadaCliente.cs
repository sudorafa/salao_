using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Projeto4_Junior.Negocios
{
    class FachadaCliente : IFachadaCliente
    {
        public IFachadaCliente ifachada = new ControladorCliente();        

        public void CadastrarCliente(Cliente cliente)
        {
            this.ifachada.CadastrarCliente(cliente);
        }
        public Cliente BuscarCliente(String cpf)
        {
           return this.ifachada.BuscarCliente(cpf);
        }
        public void RemoverCliente(String cpf)
        {
            this.ifachada.RemoverCliente(cpf);
        }
        public void AlterarCliente(Cliente cliente)
        {
            this.ifachada.AlterarCliente(cliente);
        }
        public ArrayList ListarCliente(String busca)
        {
            return this.ifachada.ListarCliente(busca);
        }
        
    }
}
