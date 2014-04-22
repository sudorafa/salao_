using Projeto4_Junior.Modelo;
using System;
using System.Collections;
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
        public Funcionario BuscarFuncionario(String cpf)
        {
            return this.ifachada.BuscarFuncionario(cpf);
        }
        public void RemoverFuncionario(String cpf)
        {
            this.ifachada.RemoverFuncionario(cpf);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {
            this.ifachada.AlterarFuncionario(funionario);
        }

        public bool VerificaFunc(String cpf)
        {
           return this.ifachada.VerificaFunc(cpf);
        
        }
        public ArrayList ListarFuncionario(String buscar)
        {
            return this.ifachada.ListarFuncionario(buscar);
        }

    }
}
