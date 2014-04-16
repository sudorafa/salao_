using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        Usuario BuscarUsuario(String login);
        void RemoverUsuario(String login);
        void AlterarUsuario(Usuario usuario);
        bool Autenticar(String usuario, String senha);
        bool VerificarUsuarioExistente(String login);
        bool VerificaTipoUsuario(String login);
        ArrayList ListarUsuario(String busca);

    }
}
