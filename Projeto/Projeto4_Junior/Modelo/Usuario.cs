using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class Usuario
    {
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public int isGestor { get; set; }


        public Usuario()
        {

        }
        public Usuario(String nome, String login, String senha, int isgestor)
        {
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.isGestor = isgestor;
        }
    }
}
