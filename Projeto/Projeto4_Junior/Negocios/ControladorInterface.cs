using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto4_Junior.Negocios
{
    class ControladorInterface : IFachada
    {
        public IFachada ifachada { get; set; }



        public void CadastrarFuncionario(Funcionario funionario)
        {
            this.ifachada.CadastrarFuncionario(funionario);
        }
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
            return this.ifachada.BuscarFuncionario(funionario);
        }
        public void RemoverFuncionario(Funcionario funionario)
        {
            this.ifachada.RemoverFuncionario(funionario);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {
            this.ifachada.AlterarFuncionario(funionario);
        }

        public void CadastrarProdutos(Produto produto)
        {
            this.ifachada.CadastrarProdutos(produto);
        }
        public Produto BuscarProdutos(Produto produto)
        {
           return this.ifachada.BuscarProdutos(produto);
        }
        public void RemoverProdutos(Produto produto)
        {
            this.ifachada.RemoverProdutos(produto);
        }
        public void AlterarProdutos(Produto produto)
        {
            this.ifachada.AlterarProdutos(produto);
        }

        public void CadastrarCliente(Cliente cliente)
        {
            this.ifachada.CadastrarCliente(cliente);
        }
        public Cliente BuscarCliente(Cliente cliente)
        {
           return this.ifachada.BuscarCliente(cliente);
        }
        public void RemoverCliente(Cliente cliente)
        {
            this.ifachada.RemoverCliente(cliente);
        }
        public void AlterarCliente(Cliente cliente)
        {
            this.ifachada.AlterarCliente(cliente);
        }

        public void CadastrarServico(Servico servico)
        {
            this.ifachada.CadastrarServico(servico);
        }
        public Servico BuscarServico(Servico servico)
        {
            return this.ifachada.BuscarServico(servico);
        }
        public void RemoverServico(Servico servico)
        {
            this.ifachada.RemoverServico(servico);
        }
        public void AlterarServico(Servico servico)
        {
            this.ifachada.AlterarServico(servico);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            this.ifachada.CadastrarUsuario(usuario);
        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            return this.ifachada.BuscarUsuario(usuario);
        }
        public void RemoverUsuario(Usuario usuario)
        {
            this.ifachada.RemoverUsuario(usuario);
        }

        public void AlterarUsuario(Usuario usuario)
        {
            this.ifachada.AlterarUsuario(usuario);
        }
    }
}
