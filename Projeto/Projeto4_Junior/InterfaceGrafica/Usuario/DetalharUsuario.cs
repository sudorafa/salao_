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
        public DetalharUsuario()
        {
            InitializeComponent();
        }

        public DetalharUsuario(Projeto4_Junior.Modelo.Usuario usu)
        {
            InitializeComponent();
            Nome_Usu.Text = usu.Nome;
            Login_Usu.Text = usu.Login;
            Senha_Usu.Text = usu.Senha;
            if (usu.isGestor == 1)
            {
                Tipo_Usu.Text = "Gestor";
            }
            else
            {
                Tipo_Usu.Text = "Usuario";
            }
        }

        private void DetalharUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
