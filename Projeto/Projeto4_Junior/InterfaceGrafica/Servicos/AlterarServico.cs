using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;

namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    public partial class AlterarServico : Form
    {
        String idServicoParaServico;
        private Servico servic;
        private FormularioListarServico FormularioListarServico;

        
        public AlterarServico(Servico servic, FormularioListarServico FormularioListarServico)
        {
            InitializeComponent();

            campoDescricaoTelaAlterar.Text = servic.Descricao;
            campoValorTelaAlterar.Text = Convert.ToString(servic.Valor);
            
            this.servic = servic;
            this.FormularioListarServico = FormularioListarServico;
                        
        }
        public AlterarServico()
        {
            InitializeComponent();
        }

        private void AlterarServico_Load(object sender, EventArgs e)
        {
            this.idServicoParaServico = campoDescricaoTelaAlterar.Text;

        }

        private void botaoCancelarTelaAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoAlterarTelaAlterar_Click(object sender, EventArgs e)
        {
            IfachadaServico fachadaServico = new FachadaServico();
            Servico servico = new Servico();           

            if (campoDescricaoTelaAlterar.Text == null || campoDescricaoTelaAlterar.Text.Equals("") ||
               campoValorTelaAlterar.Text == null || campoValorTelaAlterar.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                servico.Descricao = campoDescricaoTelaAlterar.Text;
                servico.Valor = Convert.ToDecimal(campoValorTelaAlterar.Text);
                

                fachadaServico.AlterarServico(servico,idServicoParaServico);
                this.Close();
            }
        }
    }
}
