using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Cliente
{
    public partial class DetalharCliente : Form
    {
        private Modelo.Cliente cliente;

        public DetalharCliente()
        {
            InitializeComponent();
        }

        public DetalharCliente(Modelo.Cliente cliente)
        {
            InitializeComponent();
            tbNome.Text = cliente.Nome;
            tbCpf.Text = cliente.Cpf;
            tbTelefone.Text = cliente.Telefone;
            tbDataNascimento.Text = cliente.DataNascimento;
            tbEmail.Text = cliente.Email;
            tbEndereco.Text = cliente.Endereco;
        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
