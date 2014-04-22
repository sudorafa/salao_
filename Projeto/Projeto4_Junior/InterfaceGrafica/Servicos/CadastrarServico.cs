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
                    
                IfachadaServico fachadaServico = new FachadaServico();
                Servico servico = new Servico();

                servico.Descricao = campoDescricao.Text;
                servico.Valor = Convert.ToDecimal(campoValor.Text);
                
               
                if (campoDescricao.Equals("") || campoDescricao == null || campoValor.Equals("") || campoValor == null)
                {
                    MessageBox.Show("Por favor, preencher todos os campos");
                    servico.Descricao = campoDescricao.Text;
                }
                else
                {
                    servico.Descricao = campoDescricao.Text;   
                    servico.Valor = Convert.ToDecimal(campoValor.Text);
                    servico.Ativo = true;
                    fachadaServico.CadastrarServico(servico);
                    this.Close();
                }
                
           
            }
        }
    }

