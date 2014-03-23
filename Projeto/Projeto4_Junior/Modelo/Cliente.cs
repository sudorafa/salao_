using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Projeto4_Junior.Modelo
{
    class Cliente
    {
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Cpf { get; set; }
        public String Data_Nascimento { get; set; }
        public ArrayList Telefone { get; set; }
        
        public Cliente()
        {

        }

        public Cliente(String nome, String endereco, String cpf, String data_nascimento, ArrayList telefone)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.Data_Nascimento = data_nascimento;
            this.Telefone = telefone;
           
        }

    
            
    }
}
