using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    class FachadaUsuario : IfachadaUsuario
    {
        public IfachadaUsuario ifachada = new ControladorUsuario();

        public void CadastrarUsuario(Usuario usuario)
        {
            this.ifachada.CadastrarUsuario(usuario);
        }
        public Usuario BuscarUsuario(String login)
        {
            return this.ifachada.BuscarUsuario(login);
        }
        public void RemoverUsuario(String login)
        {
            this.ifachada.RemoverUsuario(login);
        }
        public void AlterarUsuario(Usuario usuario)
        {
            this.ifachada.AlterarUsuario(usuario);
        }
        public bool Autenticar(string usuario, string senha)
        {
            return this.ifachada.Autenticar(usuario, senha);
            throw new NotImplementedException();
        }
        public bool VerificaTipoUsuario(String login)
        {
            return this.ifachada.VerificaTipoUsuario(login);
        }
        public ArrayList ListarUsuario(String busca)
        {
            return this.ifachada.ListarUsuario(busca);
        }
    }
}
