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

namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    public partial class AlterarServicoPrincipal : Form
    {
        public AlterarServicoPrincipal()
        {
            InitializeComponent();
        }

        private void AlterarServicoPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void PreencherServico(int IdServico)
        {
            Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();
                   
            campoCodigoServico_FormeTelaPrincipal.Text = Convert.ToString(IdServico);
            
        }

        private void botaoAlterarTelaServicoPrincipal_Click(object sender, EventArgs e)
        {
            bool key = true;

            String[] campo = new String[3] 
            {
                campoCodigoServico_FormeTelaPrincipal.Text,
                campoDescricaoServico_FormeTelaPrincipal.Text,
                campoValorServico_FormeTelaPrincipal.Text                
            };

            for (int x = 0; x < campo.Length; x++)
            {
                if (campo[x] == null || campo[x].Equals(""))
                {
                    key = false;
                }
            }

            if (key == true)
            {
                IfachadaServico fachadaServico = new FachadaServico();
                Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();

                servico.IdServico = Convert.ToInt32(campo[0]);
                servico.Descricao = campo[1];
                servico.Valor = Convert.ToDecimal(campo[2]);

                fachadaServico.AlterarServico(servico);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
