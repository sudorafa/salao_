using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    abstract class Pessoa
    {

        
        public string CPF { get; private set; }
        public string NOME { get; private set; }
        public string DATA_NASCIMENTO { get; private set; }
        public string  EMAIL { get; private set; }
        public string RG { get; private set; }

        public Pessoa()
        {
        }

        public Pessoa(string cpf, string nome, string data_N, string email, string rg)
        {
            this.CPF = cpf;
            this.NOME = nome;
            this.DATA_NASCIMENTO = data_N;
            this.EMAIL = email;
            this.RG = rg;           
        }

    }

    }
