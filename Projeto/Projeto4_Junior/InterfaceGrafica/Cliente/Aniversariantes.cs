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

namespace Projeto4_Junior.InterfaceGrafica.Cliente
{
    public partial class Aniversariantes : Form
    {
        String mascaraVazia;
        public Aniversariantes()
        {
            InitializeComponent();
        }

        private void Aniversariantes_Load(object sender, EventArgs e)
        {
            mascaraVazia = DataBuscada.Text;
        }


        private void Buscar_Click(object sender, EventArgs e)
        {
            IFachadaCliente fachada = new FachadaCliente();

            if (DataBuscada.Text.Equals(mascaraVazia))
            {
                DateTime data = DateTime.Now;


                string dataAtual = String.Format("{0:dd/MM}", data);

                ArrayList lista = fachada.BuscarAniversariantes(dataAtual);

                if (lista.Count == 0)
                {
                    MessageBox.Show("Não há clientes aniversariando hoje!");
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    foreach (var cli in lista)
                    {
                        Projeto4_Junior.Modelo.Cliente cliente = new Projeto4_Junior.Modelo.Cliente();
                        cliente = (Projeto4_Junior.Modelo.Cliente)cli;

                        dataGridView1.Rows.Add(cliente.Nome, cliente.Cpf);
                    }
                }
            }
            else
            {
                String data = DataBuscada.Text;
                ArrayList lista = fachada.BuscarAniversariantes(data);

                if (lista.Count == 0)
                {
                    MessageBox.Show("Não há clientes aniversariando nesta data!");
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    foreach (var cli in lista)
                    {
                        Projeto4_Junior.Modelo.Cliente cliente = new Projeto4_Junior.Modelo.Cliente();
                        cliente = (Projeto4_Junior.Modelo.Cliente)cli;

                        dataGridView1.Rows.Add(cliente.Nome, cliente.Cpf);
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IFachadaCliente fachada = new FachadaCliente();

            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["nome"].Index)
            {
                String cpf = (String)dataGridView1[1, e.RowIndex].Value;
                
                Projeto4_Junior.Modelo.Cliente cliente = fachada.BuscarCliente(cpf);

                DetalharCliente tela = new DetalharCliente(cliente);
                tela.ShowDialog();
            }
        }

       
    }
}
