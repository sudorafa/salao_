using Projeto4_Junior.Negocios;
using System;
using System.Collections;
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
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void BuscarListaUsuario_Click(object sender, EventArgs e)
        {
            IfachadaUsuario fachadausuario = new FachadaUsuario();
            ArrayList lista = fachadausuario.ListarUsuario(Usuario_Buscado.Text);
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Usuario usuario = new Projeto4_Junior.Modelo.Usuario();
                usuario = (Projeto4_Junior.Modelo.Usuario)func;
                // PREENCHE AS COLUNAS DE 'Nome', 'Login' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(usuario.Nome, usuario.Login, "Remover", "Alterar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IfachadaUsuario fachadausuario = new FachadaUsuario();

            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir " + dataGridView1[0, e.RowIndex].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    //REMOVER O FUNCIONARIO SELECIONADO
                    String login = (String)dataGridView1[1, e.RowIndex].Value;
                    fachadausuario.RemoverUsuario(login);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.BuscarListaUsuario_Click(sender, e);
                }
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
            {
                    //Carrega usuario que vai ser alterado!
                    String login = (String)dataGridView1[1, e.RowIndex].Value;
                    Projeto4_Junior.Modelo.Usuario usu = fachadausuario.BuscarUsuario(login);

                    AlterarUsuario tela = new AlterarUsuario(usu, this);
                    tela.ShowDialog();
             }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["nome"].Index)
            {
                // Caso o nome da coluna seja outro troca o nome do indice em cima.

                String login = (String)dataGridView1[1, e.RowIndex].Value;
                //Carrega o funcionario para ser detalhado.
                Projeto4_Junior.Modelo.Usuario usu = fachadausuario.BuscarUsuario(login);

                DetalharUsuario tela = new DetalharUsuario(usu);
                tela.ShowDialog();
            }

            }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {

        }
        }
    }
