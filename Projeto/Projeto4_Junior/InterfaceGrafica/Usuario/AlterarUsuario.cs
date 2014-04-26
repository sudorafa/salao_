using Projeto4_Junior.Negocios;
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
        private ListarUsuario listarUsuario;
        String login; 

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
           login = Login_Usuario.Text;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if(Nome_Usuario.Text == null  || Nome_Usuario.Text.Equals("") ||
               Login_Usuario.Text == null || Login_Usuario.Text.Equals("")||
               Senha_Usuario.Text == null || Senha_Usuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                
                Projeto4_Junior.Modelo.Usuario usuario = new Projeto4_Junior.Modelo.Usuario();
                usuario.Nome = Nome_Usuario.Text;
                usuario.Login = Login_Usuario.Text;
                usuario.Senha = Senha_Usuario.Text;
                if(isGestor.Checked == true)
                {
                    usuario.isGestor = 1;
                }
                else
                {
                    usuario.isGestor = 0;    
                }

                IfachadaUsuario fachada = new FachadaUsuario();
                fachada.AlterarUsuario(usuario, login);
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
