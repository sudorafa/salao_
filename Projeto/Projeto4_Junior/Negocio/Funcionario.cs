using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    class Funcionario : Pessoa
    {
        public Funcionario()
        {

        }
        public Funcionario(String nome, String cpf, DateTime data_nasc, String email,
                      Endereco end, int tel)
        {
            base.Nome = nome;
            base.Cpf = cpf;
            base.Data_Nascimento = data_nasc;
            base.Email = email;
        }
    }
}
