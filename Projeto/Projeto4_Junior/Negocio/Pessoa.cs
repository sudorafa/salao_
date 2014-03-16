using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    abstract class Pessoa
    {

        
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string  Email { get; set; }
        public Pessoa()
        {
        }

        public Pessoa(string cpf, string nome, DateTime data_N, string email,)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Data_Nascimento = data_N;
            this.Email = email;                 
        }

    }
}

    

