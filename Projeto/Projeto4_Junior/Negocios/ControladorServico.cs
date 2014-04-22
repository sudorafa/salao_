using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
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
    class ControladorServico : IfachadaServico
    {
        private IBancoDadosServico ibancodados = new BancoDadosServico();
           
        public void CadastrarServico(Servico servico)//--------foi acrescentado --------------//
        {
            if (ibancodados.VerificaExistenciaServico(servico.IdServico) == false)
            {
                ibancodados.CadastrarServico(servico);
            }
            else
            {
                MessageBox.Show("Servico já existente");
            }  
            
        }
        public Servico BuscarServico(Servico servico)
        {
            return ibancodados.BuscarServico(servico);
            
            
            //return null;
        }
        public void RemoverServico(Servico servico)
        {
            /*
            if (ibancodados.VerificaExistenciaServico(IdServico) == true)
            {
                ibancodados.RemoverServico(IdServico);
            }
            else
            {
                MessageBox.Show("Servico não cadastrado!");
            } 
             * */
            
        }
        public void AlterarServico(Servico servico)
        {
            /*
            if (ibancodados.VerificaExistenciaServico(servico.IdServico) == true)
            {
                AlterarClientePrincipal alterar = new AlterarClientePrincipal();//estar faltando fazer o classe AlterarClientePrincipal.cs 
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
             * */
            
        }
        public ArrayList ListarServico(String busca)
        {
            return this.ibancodados.ListarServico(busca);
        }
    }
}
