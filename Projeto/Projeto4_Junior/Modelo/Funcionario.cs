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
        
        // public ArrayList Telefone { get; set; }
        // Alerado o Telefone para string - Paulo César Correia
        public String Telefone { get; set; }        
        public Double Porcentagem { get; set; }

        // Para quer server os atributos abaixo???? - Paulo César Correia
        public int IdGestor { get; set; }
        public int Login { get; set; }
        public string telefone2 { get; set; }


        public Funcionario()
        {

        }
        public Funcionario(String nome, String endereco, String cpf, String data_nascimento, String telefone,
            Double porcentagem)
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
