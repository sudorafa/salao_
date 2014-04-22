using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Caixa
{
    public partial class TelaAbrirCaixa : Form
    {
        public TelaAbrirCaixa()
        {
            InitializeComponent();

            cbFuncionario.Items.Add("teste");
            cbFuncionario.Items.Add("teste2");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaAbrirCaixa_Load(object sender, EventArgs e)
        {

        }

        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
