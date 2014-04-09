using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDadosUsuario : IBancoDadosUsuario
    {
        public IBancoDadosUsuario ibancodados = new PersistenciaUsuario();

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
        public bool Autenticar(String usuario, String senha)
        {
            return this.ibancodados.Autenticar(usuario, senha);
        }
        public bool VerificarUsuarioExistente(String login)
        {
            return ibancodados.VerificarUsuarioExistente(login);
        }
        public bool VerificaTipoUsuario(String login)
        {
            return this.ibancodados.VerificaTipoUsuario(login);
        }

        public ArrayList ListarUsuario(String busca)
        {
            return this.ibancodados.ListarUsuario(busca);
        }


    }
}
