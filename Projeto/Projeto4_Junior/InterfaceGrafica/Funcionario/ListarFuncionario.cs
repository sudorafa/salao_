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

namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    public partial class ListarFuncionario : Form
    {
        public ListarFuncionario()
        {
            InitializeComponent();
        }

        public void btBurcarFuncionario_Click(object sender, EventArgs e)
        {
            // LISTA OS FUNCIONARIO A PARTIR DO CAMPO DE BUSCA
            IfachadaFuncionario fachadaFuncionario = new FachadaFuncionario();
            ArrayList lista = fachadaFuncionario.ListarFuncionario(tbNomeFuncionario.Text);
            //A função abaixo limpa o dataGridView, caso tenha uma nova busca
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Funcionario funcionario = new Projeto4_Junior.Modelo.Funcionario();
                funcionario = (Projeto4_Junior.Modelo.Funcionario)func;
                // PREENCHE AS COLUNAS DE 'NOME', 'CPF' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(funcionario.Nome, funcionario.Cpf, "Remover", "Alterar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IfachadaFuncionario fachadaFuncionario = new FachadaFuncionario();
            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir " + dataGridView1[0, e.RowIndex].Value + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    //REMOVER O FUNCIONARIO SELECIONADO
                    String cpf = (String)dataGridView1[1, e.RowIndex].Value;
                    fachadaFuncionario.RemoverFuncionario(cpf);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.btBurcarFuncionario_Click(sender, e);
                }
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
            {
                //ABRI A JANELA PARA ALTERAR O FUNCIONARIO SELECIONADO
                String cpf = (String)dataGridView1[1, e.RowIndex].Value;
                //Carrega o funcionario para ser alterado.
                Projeto4_Junior.Modelo.Funcionario func = fachadaFuncionario.BuscarFuncionario(cpf);

                AlterarFuncionario tela = new AlterarFuncionario(func, this);
                tela.ShowDialog();
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["nome"].Index)
            {
                // Caso o nome da coluna seja outro troca o nome do indice em cima.

                String cpf = (String)dataGridView1[1, e.RowIndex].Value;
                //Carrega o funcionario para ser detalhado.
                Projeto4_Junior.Modelo.Funcionario func = fachadaFuncionario.BuscarFuncionario(cpf);

                DetalharFuncionario tela = new DetalharFuncionario(func);
                tela.ShowDialog();
            }
        }

        private void ListarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
