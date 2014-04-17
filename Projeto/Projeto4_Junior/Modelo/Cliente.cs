using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto4_Junior.Modelo
{
    public class Cliente
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String Cpf { get; set; }
        public String DataNascimento { get; set; }
        public String Telefone { get; set; }
        public Boolean Ativo { get; set; }


        public Cliente()
        {

        }

        public Cliente(String nome, String email, String endereco, String cpf, String data_nascimento, String telefone)
        {
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.DataNascimento = data_nascimento;
            this.Telefone = telefone;

        }
    }
}
