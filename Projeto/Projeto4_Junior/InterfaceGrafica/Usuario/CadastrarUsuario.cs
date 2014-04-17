using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;

namespace Projeto4_Junior
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void Salvar_Usuario_Click(object sender, EventArgs e)
        {
            if (Nome_Usuario.Text == null || Nome_Usuario.Text.Equals("")
                || Login_Usuario.Text == null || Login_Usuario.Text.Equals("")
                || Senha_Usuario.Text == null || Senha_Usuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                IfachadaUsuario fachadaUSuario = new FachadaUsuario();
                Usuario usuario = new Usuario();

                usuario.Nome = Nome_Usuario.Text;
                usuario.Login = Login_Usuario.Text;
                usuario.Senha = Senha_Usuario.Text;
                usuario.Ativo = true;

                if (isGestor.Checked == true)
                {
                    usuario.isGestor = 1;
                }
                else
                {
                    usuario.isGestor = 0;
                }

                fachadaUSuario.CadastrarUsuario(usuario);
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
