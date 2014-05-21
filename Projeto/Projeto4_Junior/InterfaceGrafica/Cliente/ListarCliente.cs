using Projeto4_Junior.InterfaceGrafica.Cliente;
using Projeto4_Junior.Modelo;
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

namespace Projeto4_Junior
{
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IFachadaCliente fachadaCliente = new FachadaCliente();
            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["remover"].Index)
            {
               DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir "+dataGridView1[0,e.RowIndex].Value+"?","" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    String cpf = (String)dataGridView1[1,e.RowIndex].Value;
                    fachadaCliente.RemoverCliente(cpf);
                    //A função abaixo limpa o dataGridView
                    dataGridView1.Rows.Clear();
                    //A função abaixo preenche o dataGridView
                    this.BuscarListaCliente_Click(sender, e);
                }
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["alterar"].Index)
            {
                String cpf = (String)dataGridView1[1,e.RowIndex].Value;
                //Carrega o cliente para ser alterado.
                Cliente cli = fachadaCliente.BuscarCliente(cpf);
               
                AlterarClientePrincipal tela = new AlterarClientePrincipal(cli, this);
                tela.ShowDialog();
            }
            else if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["nome"].Index)
            {
                // Caso o nome da coluna seja outro troca o nome do indice em cima.

                String cpf = (String)dataGridView1[1, e.RowIndex].Value;
                //Carrega o funcionario para ser detalhado.
                Projeto4_Junior.Modelo.Cliente cliente = fachadaCliente.BuscarCliente(cpf);

                DetalharCliente tela = new DetalharCliente(cliente);
                tela.ShowDialog();
            }
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeto4DataSet.Cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.projeto4DataSet.Cliente);

        }

        public void BuscarListaCliente_Click(object sender, EventArgs e)
        {

            IFachadaCliente fachadaCliente = new FachadaCliente();
            ArrayList lista = fachadaCliente.ListarCliente(nomeClienteBusca.Text);
            //A função abaixo limpa o dataGridView, caso tenha uma nova busca
            dataGridView1.Rows.Clear();
            foreach (var cli in lista)
            {
                Cliente cliente = new Cliente();
                cliente = (Cliente)cli;

                dataGridView1.Rows.Add( cliente.Nome, cliente.Cpf, "Remover","Alterar");
            }
               
        }

        private void nomeClienteBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
