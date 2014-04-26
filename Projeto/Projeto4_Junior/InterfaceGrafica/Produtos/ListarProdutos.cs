using Projeto4_Junior.Negocios;
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

namespace Projeto4_Junior.InterfaceGrafica.Produtos
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void BuscarProduto_Click(object sender, EventArgs e)
        {
            // LISTA OS FUNCIONARIO A PARTIR DO CAMPO DE BUSCA
            IfachadaProduto fachadaProduto = new FachadaProduto();
            ArrayList lista = fachadaProduto.ListarProduto(ProdutoBuscado.Text);
            //A função abaixo limpa o dataGridView, caso tenha uma nova busca
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Produto produto = new Projeto4_Junior.Modelo.Produto();
                produto = (Projeto4_Junior.Modelo.Produto)func;
                // PREENCHE AS COLUNAS DE 'NOME', 'CPF' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(produto.Descricao, produto.Valor, produto.Quantidade, "Remover", "Alterar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IfachadaProduto fachada = new FachadaProduto();

            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir " + dataGridView1[0, e.RowIndex].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    //REMOVER O FUNCIONARIO SELECIONADO
                    String descricao = (String)dataGridView1[0, e.RowIndex].Value;
                    fachada.RemoverProduto(descricao);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.BuscarProduto_Click(sender, e);
                }
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
            {
                
                //Carrega usuario que vai ser alterado!
                String descricao = (String)dataGridView1[0, e.RowIndex].Value;
                Projeto4_Junior.Modelo.Produto prod = fachada.BuscarProduto(descricao);

                AlterarProduto tela = new AlterarProduto(prod, this);
                tela.ShowDialog();
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["Descricao"].Index)
            {
                // Caso o nome da coluna seja outro troca o nome do indice em cima.

                String descricao = (String)dataGridView1[0, e.RowIndex].Value;
                //Carrega o funcionario para ser detalhado.
                Projeto4_Junior.Modelo.Produto prod = fachada.BuscarProduto(descricao);

                DetalharProduto tela = new DetalharProduto(prod);
                tela.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

