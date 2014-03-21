using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    class Gestor
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Boolean E_Gestor { get; set; }

        public Gestor()
        {

        }

        public Gestor(String nome, String login, String senha)
        {
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.E_Gestor = true;
        }

        public void Cadastrar_Cliente(Cliente cliente)
        {

        }

        public void Alterar_Cliente(String Cpf)
        {

        }

        public void Remover_Cliente(String Cpf)
        {

        }

        public List<Cliente> Listar_Cliente()
        {
            return null;
        }

        public List<Cliente> Verificar_Anivessariantes()
        {
            return null;
        }


        public void Novo_Servico()
        {

        }

        public void Alterar_servico(int codogo_servico)
        {

        }
        public List<Servico> Listar_Servicos()
        {

            return null;

        }

        public void Remover_Servico(int codigo_servico)
        {

        }

        public void Cadastrar_Usuario(Usuario usuario)
        {

        }

        public void Alterar_Usuario(String login)
        {

        }

        public void Remover_Usiario(String login)
        {

        }

        public List<Usuario> Listar_Usuarios(String login)
        {
            return null;
        }

        public void Relatorio_Balanco_dia()
        {

        }

        public List<Servico> Relatorio_Servicos_Funcionario()
        {
            return null;
        }
        public List<Servico> Relatorio_Servicos_Cliente()
        {
            return null;
        }

        public void Relatorio_Conveniencia()
        {

        }




    }
}
