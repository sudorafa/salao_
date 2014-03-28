using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Windows.Forms;

namespace Projeto4_Junior.Negocios
{
    class ControladorCliente : IFachadaCliente
    {
        IBancoDadosCliente ibancodados = new BancoDadosCliente();
        
        public void CadastrarCliente(Cliente cliente)
        {
            if (ibancodados.VerificaExistenciaCliente(cliente.Cpf) == false)
            {
                ibancodados.CadastrarCliente(cliente);
            }
            else
            {
                MessageBox.Show("Cliente já existente");
            }
           
        }
        public Cliente BuscarCliente(Cliente cliente)
        {
            //Implementações e validações...

            return ibancodados.BuscarCliente(cliente);
        }
        public void RemoverCliente(Cliente cliente)
        {
            //Implementações e validações...

            ibancodados.RemoverCliente(cliente);
        }
        public void AlterarCliente(Cliente cliente)
        {
            //Implementações e validações...

            ibancodados.AlterarCliente(cliente);            
        }
    }
}
