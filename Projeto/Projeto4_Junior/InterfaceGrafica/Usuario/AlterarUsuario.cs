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
    public partial class AlterarUsuario : Form
    {
        private Modelo.Usuario usu;
        private ListarUsuario listarUsuario;

        public AlterarUsuario()
        {
            InitializeComponent();
        }

        public AlterarUsuario(Modelo.Usuario usu, ListarUsuario listarUsuario)
        {
            InitializeComponent();

            Nome_Usuario.Text = usu.Nome;
            Login_Usuario.Text = usu.Login;
            Senha_Usuario.Text = usu.Senha;
            if(usu.isGestor == 1)
            {
                isGestor.Checked = true;
            }
            else
            {
                isGestor.Checked = false;
            }
            

            this.listarUsuario = listarUsuario;
        }

        private void AlterarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
