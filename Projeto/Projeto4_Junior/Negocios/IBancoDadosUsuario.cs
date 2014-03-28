using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocios
{
    interface IBancoDadosUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        Usuario BuscarUsuario(Usuario usuario);
        void RemoverUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        bool Autenticar(String usuario, String senha);

    }
}
