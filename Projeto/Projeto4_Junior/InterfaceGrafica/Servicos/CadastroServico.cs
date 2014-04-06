using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    public partial class Form_Cadastro_Servico : Form
    {
        public Form_Cadastro_Servico()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

         private void Servico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void butao_salvar_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor, preencher o campo codigo de serviço.");
                                   
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Por favor, preencher o campo valor.");
            }
            else
            {
                MessageBox.Show("Serviço Cadastrado");
            }
        }

        private void butao_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}

