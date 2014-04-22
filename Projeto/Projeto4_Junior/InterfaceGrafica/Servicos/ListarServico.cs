using Projeto4_Junior.Negocios;
using Projeto4_Junior.Modelo;
using Projeto4_Junior.InterfaceGrafica.Servicos;
using System;
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

        private void BuscarListaUsuario_Click(object sender, EventArgs e)
        {
            IfachadaServico fachadaservico = new FachadaServico();
            ArrayList lista = fachadaservico.ListarServico(Servico_Buscado.Text);
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
               Servico servico = new Servico();
                servico = (Projeto4_Junior.Modelo.Servico)func;
                // PREENCHE AS COLUNAS DE 'Nome', 'Login' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(servico.Descricao, servico.Valor, "Remover", "Alterar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IfachadaServico fachadaservico = new FachadaServico();

            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir " + dataGridView1[0, e.RowIndex].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    //REMOVER O FUNCIONARIO SELECIONADO
                    String Descricao = (String)dataGridView1[1, e.RowIndex].Value;
                    fachadaservico.RemoverServico(Descricao);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.BuscarListaUsuario_Click(sender, e);
                }
                else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
                {
                    //Carrega usuario que vai ser alterado!
                    String Descricao = (String)dataGridView1[1, e.RowIndex].Value;
                    Projeto4_Junior.Modelo.Servico servico = fachadaservico.BuscarServico(Descricao);

                    //AlterarServico tela = new AlterarServico(servico, this);
                    //tela.ShowDialog();
                }
            }
        }

        private void ListarServico_Load(object sender, EventArgs e)
        {

        }

        private void Servico_Buscado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
