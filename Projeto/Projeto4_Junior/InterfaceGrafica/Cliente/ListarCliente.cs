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

        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeto4DataSet.Cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.projeto4DataSet.Cliente);

        }

        private void BuscarListaCliente_Click(object sender, EventArgs e)
        {

            IFachadaCliente fachadaCliente = new FachadaCliente();
            ArrayList lista = fachadaCliente.ListarCliente(nomeClienteBusca.Text);

            foreach (var cli in lista)
            {
                Cliente cliente = new Cliente();
                cliente = (Cliente)cli;

                dataGridView1.Rows.Add(cliente.Nome, cliente.Cpf);
            }
               
        }

        private void nomeClienteBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
