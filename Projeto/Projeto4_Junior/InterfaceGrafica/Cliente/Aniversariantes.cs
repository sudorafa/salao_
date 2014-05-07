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

                String dia = data.Day.ToString();
                String mes = data.Month.ToString();
                String ano = data.Year.ToString();

                String dataAtual = dia + "/" + mes + "/" + ano;

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

                        dataGridView1.Rows.Add(cliente.Nome);
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

                        dataGridView1.Rows.Add(cliente.Nome);
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
    }
}
