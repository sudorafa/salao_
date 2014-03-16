using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    class Cliente : Pessoa
    {
        public Endereco Endereco_Cliente { get; private set; }
        public int Telefone { get; private set; }    


        public Cliente(){

        }

        public Cliente(String nome, String cpf, DateTime data_nasc, String email, 
                       Endereco end, int tel){
                           base.Nome = nome;
                           base.Cpf = cpf;
                           base.Data_Nascimento = data_nasc;
                           base.Email = email;
                           this.Endereco_Cliente = end;
                           this.Telefone = tel;            
        }

    }

    

     


}
