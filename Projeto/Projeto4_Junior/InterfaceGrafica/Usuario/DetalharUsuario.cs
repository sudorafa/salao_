using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Usuario
{
    public partial class DetalharUsuario : Form
    {
        private Modelo.Usuario usu;

        public DetalharUsuario()
        {
            InitializeComponent();
        }

        public DetalharUsuario(Modelo.Usuario usu)
        {
            InitializeComponent();
            NomeUsu.Text = usu.Nome;
            LoginUsu.Text = usu.Login;
            SenhaUsu.Text = usu.Senha;
            if (usu.isGestor == 1)
            {
                TipoUsu.Text = "Gestor";
            }
            else
            {
                TipoUsu.Text = "Usuario";
            }

            this.usu = usu;
        }
    }
}
