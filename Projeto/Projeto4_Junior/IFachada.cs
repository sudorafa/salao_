using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto4_Junior
{
    interface IFachada
    {
        public void CadastrarFuncionario(Funcionario funionario);
        public Funcionario BuscarFuncionario(Funcionario funionario);  
        public void RemoverFuncionario(Funcionario funionario);
        public void AlterarFuncionario(Funcionario funionario);

        public void CadastrarProdutos(Produto produto);
        public Produto BuscarProdutos(Produto produto);
        public void RemoverProdutos(Produto produto);
        public void AlterarProdutos(Produto produto);

        public void CadastrarCliente(Cliente cliente);
        public Cliente BuscarCliente(Cliente cliente);
        public void RemoverCliente(Cliente cliente);
        public void AlterarCliente(Cliente cliente);

        public void CadastrarServico(Servico servico);
        public Servico BuscarServico(Servico servico);
        public void RemoverServico(Servico servico);
        public void AlterarServico(Servico servico);

        public void CadastrarUsuario(Usuario usuario);
        public  Usuario BuscarUsuario(Usuario usuario);
        public void RemoverUsuario(Usuario usuario);
        public void AlterarUsuario(Usuario usuario);

    }
}
