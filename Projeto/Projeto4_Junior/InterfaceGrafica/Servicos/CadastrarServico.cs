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

namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    public partial class FormularioCadastrarServico : Form
    {
        public FormularioCadastrarServico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(campoDescricao.Equals("") || campoDescricao == null)
            {
                MessageBox.Show("Por favor, preencher o campo de Descrição.");
            }
            else if(campoValor.Equals("") || campoValor == null)
            {
                MessageBox.Show("Por favor, preencher o campo VALOR.");
            }
            else
            {
                IfachadaServico fachadaServico = new FachadaServico();
                Servico servico = new Servico();

                servico.Descricao = campoDescricao.Text;
                servico.Valor = Convert.ToDecimal(campoValor.Text);
                
                if (isGestor.Checked == true)
                {
                    servico.isGestor = 1;
                }
                else
                {
                    servico.isGestor = 0;
                }

                fachadaServico.CadastrarServico(servico);
                this.Close();
            }
        }
    }
}
