using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Projeto4_Junior.Banco
{
    class BancoDadosFuncionario : IBancoDadosFuncionario
    {

        public IBancoDadosFuncionario ibancodados = new PersistenciaFuncionario();

        public void CadastrarFuncionario(Funcionario funionario)
        {           
            ibancodados.CadastrarFuncionario(funionario);
        }
        public Funcionario BuscarFuncionario(String cpf)
        {
           return this.ibancodados.BuscarFuncionario(cpf);
        }
        public void RemoverFuncionario(String cpf)
        {           
            this.ibancodados.RemoverFuncionario(cpf);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {           
            this.ibancodados.AlterarFuncionario(funionario);
        }

        public SqlDataReader VerificaFunc(Funcionario funcionario)
        {

            return this.ibancodados.VerificaFunc(funcionario);
        
        }
        public ArrayList ListarFuncionario(String buscar)
        {
            return this.ibancodados.ListarFuncionario(buscar);
        }

    }
    
}
