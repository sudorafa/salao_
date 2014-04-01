using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto4_Junior.Banco
{
    class BancoDadosFuncionario : IBancoDadosFuncionario
    {

        public IBancoDadosFuncionario ibancodados = new PersistenciaFuncionario();

        public void CadastrarFuncionario(Funcionario funionario)
        {           
            ibancodados.CadastrarFuncionario(funionario);
        }
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
           return this.ibancodados.BuscarFuncionario(funionario);
        }
        public void RemoverFuncionario(Funcionario funionario)
        {           
            this.ibancodados.RemoverFuncionario(funionario);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {           
            this.ibancodados.AlterarFuncionario(funionario);
        }

        public SqlDataReader VerificaFunc(Funcionario funcionario)
        {

            return this.ibancodados.VerificaFunc(funcionario);
        
        }

    }
    
}
