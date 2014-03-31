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
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
            return null;
        }
         public void RemoverFuncionario(Funcionario funionario)
        {
            ibancodados.RemoverFuncionario(funionario);
            MessageBox.Show("Dados excluidos com sucesso !!");
        }
         public void AlterarFuncionario(Funcionario funionario)
         {
             ibancodados.AlterarFuncionario(funionario);
             MessageBox.Show("Alteração efetuada com sucesso !!!");
         }
    }
}
