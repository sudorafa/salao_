using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto4_Junior.Negocios;
using Projeto4_Junior.Modelo;

namespace Projeto4_Junior
{
    public partial class Form_AlterarCliente : Form
    {
        public Form_AlterarCliente()
        {
            InitializeComponent();
        }

        private void button_CancelarAlteraracaoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AlterarCliente_Click(object sender, EventArgs e)
        {
            IFachadaCliente fachadaCliente = new FachadaCliente();
            Cliente cliente = new Cliente();
            cliente.Cpf = textBox_AlterarCliente.Text;
            fachadaCliente.AlterarCliente(cliente);
            this.Close();
        }
    }
}
