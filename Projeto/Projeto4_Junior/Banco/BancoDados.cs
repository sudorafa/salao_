using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDados
    {
        public  IBancoDados ibancodados { get; set; }


        public void CadastrarFuncionario(Funcionario funionario)
        {
            this.ibancodados.CadastrarFuncionario(funionario);
        }
        public Funcionario BuscarFuncionario(Funcionario funionario)
        {
            return this.ibancodados.BuscarFuncionario(funionario);
        }
        public void RemoverFuncionario(Funcionario funionario)
        {
            this.ibancodados.RemoverFuncionario(funionario);
        }
        public void AlterarFuncionario(Funcionario funionario)
        {
            this.ibancodados.AlterarFuncionario(funionario);
        }

        public void CadastrarProdutos(Produto produto)
        {
            this.ibancodados.CadastrarProdutos(produto);
        }
        public Produto BuscarProdutos(Produto produto)
        {
           return this.ibancodados.BuscarProdutos(produto);
        }
        public void RemoverProdutos(Produto produto)
        {
            this.ibancodados.RemoverProdutos(produto);
        }
        public void AlterarProdutos(Produto produto)
        {
            this.ibancodados.AlterarProdutos(produto);
        }

        public void CadastrarCliente(Cliente cliente)
        {
            this.ibancodados.CadastrarCliente(cliente);
        }
        public Cliente BuscarCliente(Cliente cliente)
        {
           return this.ibancodados.BuscarCliente(cliente);
        }
        public void RemoverCliente(Cliente cliente)
        {
            this.ibancodados.RemoverCliente(cliente);
        }
        public void AlterarCliente(Cliente cliente)
        {
            this.ibancodados.AlterarCliente(cliente);
        }

        public void CadastrarServico(Servico servico)
        {
            this.ibancodados.CadastrarServico(servico);
        }
        public Servico BuscarServico(Servico servico)
        {
            return this.ibancodados.BuscarServico(servico);
        }
        public void RemoverServico(Servico servico)
        {
            this.ibancodados.RemoverServico(servico);
        }
        public void AlterarServico(Servico servico)
        {
            this.ibancodados.AlterarServico(servico);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            this.ibancodados.CadastrarUsuario(usuario);
        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            return this.ibancodados.BuscarUsuario(usuario);
        }
        public void RemoverUsuario(Usuario usuario)
        {
            this.ibancodados.RemoverUsuario(usuario);
        }

        public void AlterarUsuario(Usuario usuario)
        {
            this.ibancodados.AlterarUsuario(usuario);
        }
    }
    
}
