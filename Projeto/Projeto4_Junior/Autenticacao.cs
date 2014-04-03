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

namespace Projeto4_Junior
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Aviso.ForeColor = System.Drawing.Color.Red;
        }

        private void Autenticacao_Load(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if(usuario.Text == null || usuario.Text.Equals("") || senha.Text == null || senha.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                IfachadaUsuario Umusuario = new FachadaUsuario();
                String login = usuario.Text;
                String Umasenha = senha.Text;

                if (Umusuario.Autenticar(login, Umasenha) == true)
                {                   
                    MessageBox.Show("Seja bem vindo!");
                    bool gestor = Umusuario.VerificaTipoUsuario(login);
                    Form_Index form = new Form_Index(gestor);                    
                    form.Show();                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                    usuario.Clear();
                    senha.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
