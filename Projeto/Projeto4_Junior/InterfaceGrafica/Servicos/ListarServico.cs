using System;
using Projeto4_Junior.Negocios;
using System.Collections;
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
    public partial class FormularioListarServico : Form
    {
        public FormularioListarServico()
        {
            InitializeComponent();
        }

        private void BuscarListaServico_Click(object sender, EventArgs e)
        {
            IfachadaServico fachadaservico = new FachadaServico();
            ArrayList lista = fachadaservico.ListarServico(Servico_Buscado.Text);
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();
                servico = (Projeto4_Junior.Modelo.Servico)func;
                // PREENCHE AS COLUNAS DE 'descricao', 'serviço' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(servico.Descricao,servico.Valor,"Remover", "Alterar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IfachadaServico fachadaServico = new FachadaServico();
            
            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir " + dataGridView1[0, e.RowIndex].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    String Descricao = (String)dataGridView1[1, e.RowIndex].Value;
                    fachadaServico.RemoverServico(Descricao);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.BuscarListaServico_Click(sender, e);
                }
                else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
                {
                    //Carrega servico que vai ser alterado!
                    //String Descricao = (String)dataGridView1[1, e.RowIndex].Value;
                    //Projeto4_Junior.Modelo.Servico servic = fachadaServico.BuscarServico(Descricao);

                    //AlterarServico tela = new AlterarServico(servic, this);
                    //tela.ShowDialog();
                }
            }
            
        }
    }
}
