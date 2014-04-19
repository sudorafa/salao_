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
            bool key = true;

            String[] campo = new String[3]
                {
                    campo_codigo_servico.Text,
                    campo_descricao.Text,
                    campo_valor.Text
                };

                for (int x = 0; x < campo.Length; x++)
                {
                    if (campo[x] == null || campo[x].Equals(""))
                    {
                        key = false;
                    }
                }
            
            if(key == true)
                {
                    IfachadaServico fachadaSevico = new FachadaServico();
                    Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();

                    servico.IdServico = Convert.ToInt32(campo[0]);
                    servico.Descricao = campo[1];
                    servico.Valor = Convert.ToDecimal(campo[2]);

                    fachadaSevico.CadastrarServico(servico);
                    this.Close();
                }
             
                
           }            
        }
    }

