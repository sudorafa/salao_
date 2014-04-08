using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class Funcionario
    {
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Cpf { get; set; }
        public String Data_Nascimento { get; set; }
        public String Telefone { get; set; }        
        public int Porcentagem { get; set; }



        public Funcionario()
        {

        }
        public Funcionario(String nome, String endereco, String cpf, String data_nascimento, String telefone,
            int porcentagem)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.Data_Nascimento = data_nascimento;
            this.Telefone = telefone;
            this.Porcentagem = porcentagem;
        }

    }
}
