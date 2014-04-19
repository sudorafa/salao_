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
    public partial class FormularioAlterarServico : Form
    {
        public FormularioAlterarServico()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            IfachadaServico fachadaServico = new FachadaServico();
            Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();
            servico.IdServico = Convert.ToInt32(campoRemoverServico.Text);            
            fachadaServico.AlterarServico(servico);
            this.Close();
        }

        private void FormularioAlterarServico_Load(object sender, EventArgs e)
        {

        }
    }
}
