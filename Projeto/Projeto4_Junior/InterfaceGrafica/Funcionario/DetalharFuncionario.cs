using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    public partial class DetalharFuncionario : Form
    {
        public DetalharFuncionario(Projeto4_Junior.Modelo.Funcionario func)
        {
            InitializeComponent();
            tbNome.Text = func.Nome;
            tbCpf.Text = func.Cpf;
            tbTelefone.Text = func.Telefone;
            tbDataNascimento.Text = func.DataNascimento;
            tbPorcentagem.Text = ""+func.Porcentagem;
            tbEndereco.Text = func.Endereco;
        }
        
        public DetalharFuncionario()
        {
            InitializeComponent();
        }

        private void DetalharFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
