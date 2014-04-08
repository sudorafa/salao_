using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Projeto4_Junior.Negocios
{
    class ControladorFuncionario : IfachadaFuncionario
    {
        public IBancoDadosFuncionario ibancodados = new BancoDadosFuncionario(); 

        public void CadastrarFuncionario(Funcionario funcionario)
        {          
            if (ibancodados.VerificaFunc(funcionario) == null)
            {
                ibancodados.CadastrarFuncionario(funcionario);
                MessageBox.Show("Cadastro Efetuado com sucesso !!");
            }
            else
            {
                MessageBox.Show("CPF ja cadastrado !!!");            
            }

        }
        public Funcionario BuscarFuncionario(String cpf)
        {
            return ibancodados.BuscarFuncionario(cpf);
        }
        public void RemoverFuncionario(String cpf)
        {
            ibancodados.RemoverFuncionario(cpf);
        }
         public void AlterarFuncionario(Funcionario funionario)
         {
             ibancodados.AlterarFuncionario(funionario);
         }

         public SqlDataReader VerificaFunc(Funcionario funcionario)
         {
             return ibancodados.VerificaFunc(funcionario);
         }
         public ArrayList ListarFuncionario(String buscar)
         {
             return ibancodados.ListarFuncionario(buscar);
         }
    }
}
