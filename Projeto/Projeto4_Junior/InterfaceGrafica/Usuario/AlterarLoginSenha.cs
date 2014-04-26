using System;
using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
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
    public partial class AlterarLoginSenha : Form
    {
        public AlterarLoginSenha()
        {
            InitializeComponent();
        }

        public AlterarLoginSenha(Modelo.Usuario usu)
        {
            InitializeComponent();
            SessionUser.nome = usu.Nome;
            Login_Usuario.Text = usu.Login;
            Senha_Usuario.Text = usu.Senha;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (Login_Usuario.Text == null || Login_Usuario.Text.Equals("") ||
                Senha_Usuario.Text == null || Senha_Usuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {

                Projeto4_Junior.Modelo.Usuario usuario = new Projeto4_Junior.Modelo.Usuario();
                usuario.Nome = SessionUser.nome;
                usuario.Login = Login_Usuario.Text;
                usuario.Senha = Senha_Usuario.Text;
                if (SessionUser.isGestor == true)
                {
                    usuario.isGestor = 1;
                }
                else
                {
                    usuario.isGestor = 0;
                }

                IfachadaUsuario fachada = new FachadaUsuario();
                fachada.AlterarUsuario(usuario, SessionUser.login);
                SessionUser.login = Login_Usuario.Text;
                this.Close();                                                                            
            }
        }
    }
}
