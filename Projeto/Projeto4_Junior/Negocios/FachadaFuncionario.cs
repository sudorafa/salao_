using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaFuncionario : IfachadaFuncionario
    {
        public IfachadaFuncionario ifachada = new ControladorFuncionario();

        public void CadastrarFuncionario(Funcionario funionario)
        {
            this.ifachada.CadastrarFuncionario(funionario);
        }
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
            return this.ifachada.BuscarFuncionario(funionario);
        }
        public void RemoverFuncionario(Funcionario funionario)
        {
            this.ifachada.RemoverFuncionario(funionario);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {
            this.ifachada.AlterarFuncionario(funionario);
        }

        public SqlDataReader VefificaFunc(Funcionario funcionario)
        {
           return this.ifachada.VerificaFunc(funcionario);
        
        }

    }
}
