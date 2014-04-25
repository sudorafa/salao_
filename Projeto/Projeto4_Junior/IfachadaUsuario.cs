﻿using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior
{
    interface IfachadaUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        Usuario BuscarUsuario(String login);
        void RemoverUsuario(String login);
        void AlterarUsuario(Usuario usuario, String login);
        bool Autenticar(String usuario, String senha);
        bool VerificaTipoUsuario(String login);
        ArrayList ListarUsuario(String busca);

    }
}
