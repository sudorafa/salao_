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

namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    public partial class FormularioRemoverServico : Form
    {
        public FormularioRemoverServico()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioRemoverServico_Load(object sender, EventArgs e)
        {

        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if(campoRemoverCodigoServico.Text.Equals(null) || campoRemoverCodigoServico.Text.Equals(""))
            {
                MessageBox.Show("Por favor, preencher o campo codigo de serviço para ser removido do banco de dados.");
            }
            else if(campoRemoverCodigoServico.Text != null && !campoRemoverCodigoServico.Text.Equals(""))
            {
                IfachadaServico fachadaServico = new FachadaServico();
                
                fachadaServico.RemoverServico(Convert.ToInt32(campoRemoverCodigoServico.Text));
                this.Close();
            }
        }
    }
} 
