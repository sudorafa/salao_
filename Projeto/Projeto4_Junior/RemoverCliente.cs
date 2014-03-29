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

namespace Projeto4_Junior
{
    public partial class Form_RemoverCliente : Form
    {
        public Form_RemoverCliente()
        {
            InitializeComponent();
        }

        private void button_CancelarRemocaoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_RemoverCliente_Click(object sender, EventArgs e)
        {                                                                  
            if(textBox_RemoverCliente.Text != null && !textBox_RemoverCliente.Text.Equals(""))
            {
                IFachadaCliente fachadaCliente = new FachadaCliente();

                fachadaCliente.RemoverCliente(textBox_RemoverCliente.Text);
                this.Close();          
            }
            else
            {
                MessageBox.Show("Informe o CPF!");
            }
        }
    }
}
