using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;

namespace Projeto4_Junior.Negocios
{
    class ControladorUsuario : IfachadaUsuario
    {
        private IBancoDadosUsuario ibancodados = new BancoDadosUsuario();
        public void CadastrarUsuario(Usuario usuario)
        {
            
        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            return null;
        }
        public void RemoverUsuario(Usuario usuario)
        {
            
        }

        public void AlterarUsuario(Usuario usuario)
        {
            
        }
    }
}
