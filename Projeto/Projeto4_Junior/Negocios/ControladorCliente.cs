using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Windows.Forms;
using System.Collections;

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
        public void RemoverCliente(String cpf)
        {
            if (ibancodados.VerificaExistenciaCliente(cpf) == true)
            {
                ibancodados.RemoverCliente(cpf);
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado!");
            }                
        }
        public void AlterarCliente(Cliente cliente)
        {
            if (ibancodados.VerificaExistenciaCliente(cliente.Cpf) == true)
            {
                AlterarClientePrincipal alterar = new AlterarClientePrincipal();
                if (cliente.Nome == null)
                {                    
                    alterar.PreencherCliente(cliente.Cpf);
                    alterar.ShowDialog();
                }
                else
                {
                    alterar.Close();
                    ibancodados.AlterarCliente(cliente);
                }                
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado!");
            }                        
        }
        public ArrayList ListarCliente(String busca)
        {
            return ibancodados.ListarCliente(busca);
        }
    }
}
