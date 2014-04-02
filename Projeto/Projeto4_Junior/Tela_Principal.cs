using Projeto4_Junior.InterfaceGrafica.Funcionario;
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
    public partial class Form_Index : Form
    {
        bool gestor;
        public Form_Index(bool gestor)
        {
            this.gestor = gestor; 
            InitializeComponent();
        }
        private void inserirClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroClientes cad_cli = new Form_CadastroClientes();
            cad_cli.ShowDialog();
        }

        private void alterarClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form_AlterarCliente alt_cli = new Form_AlterarCliente();
            alt_cli.ShowDialog();
        }

        private void listarClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListarClientes list_cli = new Form_ListarClientes();
            list_cli.ShowDialog();
        }

        private void removerClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form_RemoverCliente remov_cli = new Form_RemoverCliente();
            remov_cli.ShowDialog();
        }

        private void button_CadastrarClienteBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            Form_CadastroClientes cad_cli = new Form_CadastroClientes();
            cad_cli.ShowDialog();
        }

        private void Form_Index_Load(object sender, EventArgs e)
        {

            if (gestor == false)
            {
                this.funcionariosMenuItem.Enabled = false;                
            }
        }

        private void inserirUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cad_usu = new CadastrarUsuario();
            cad_usu.ShowDialog();
        }

        private void inserirFuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cad_func = new CadastroFuncionario();
            cad_func.ShowDialog();

        }

        private void menu_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
