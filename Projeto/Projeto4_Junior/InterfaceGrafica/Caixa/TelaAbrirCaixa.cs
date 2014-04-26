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

namespace Projeto4_Junior.InterfaceGrafica.Caixa
{
    public partial class TelaAbrirCaixa : Form
    {
        public TelaAbrirCaixa()
        {
            InitializeComponent();

            IfachadaFuncionario func = new FachadaFuncionario();
            ArrayList listaFunc = func.ListarFuncionario("");
            for (int i = 0; i < listaFunc.Count; i++)
            {
                Projeto4_Junior.Modelo.Funcionario funci = (Projeto4_Junior.Modelo.Funcionario)listaFunc[i];
                Projeto4_Junior.Modelo.ComboboxItem item = new Projeto4_Junior.Modelo.ComboboxItem();
                item.Text = funci.Nome;
                item.Value = funci.Cpf;
                cbFuncionario.Items.Add(item);
            }

            IfachadaServico serv = new FachadaServico();
            ArrayList listaServ = serv.ListarServico("");
            for (int i = 0; i < listaServ.Count; i++)
            {
                Projeto4_Junior.Modelo.Servico servi = new Projeto4_Junior.Modelo.Servico();
                Projeto4_Junior.Modelo.ComboboxItem item = new Projeto4_Junior.Modelo.ComboboxItem();
                servi = (Projeto4_Junior.Modelo.Servico)listaServ[i];
                item.Text = servi.Descricao + "  -  R$" + servi.Valor;
                item.Value = servi.IdServico;
                cbServicos.Items.Add(item);
            }

            IfachadaProduto prod = new FachadaProduto();
            ArrayList listaProd = prod.ListarProduto("");
            for (int i = 0; i < listaProd.Count; i++)
            {
                Projeto4_Junior.Modelo.Produto produ = new Projeto4_Junior.Modelo.Produto();
                Projeto4_Junior.Modelo.ComboboxItem item = new Projeto4_Junior.Modelo.ComboboxItem();
                produ = (Projeto4_Junior.Modelo.Produto)listaProd[i];
                item.Text = produ.Descricao + "  -  R$" + produ.Valor;
                item.Value = produ.IdProduto;
                cbProdutos.Items.Add(item);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaAbrirCaixa_Load(object sender, EventArgs e)
        {

        }

        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
