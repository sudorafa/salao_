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
        public DetalharCliente()
        {
            InitializeComponent();
        }

        public DetalharCliente(Projeto4_Junior.Modelo.Cliente cliente)
        {
            InitializeComponent();
            NomCliente.Text = cliente.Nome;
            CpfCliente.Text = cliente.Cpf;
            TelCliente.Text = cliente.Telefone;
            DataNascCliente.Text = cliente.DataNascimento;
            EndeCliente.Text = cliente.Endereco;
            EmailCliente.Text = cliente.Email;
            
        }

        private void DetalharCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
