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

        private void btBuscarCliente_Click_1(object sender, EventArgs e)
        {
            String ClienteCpfBusca = tbBuscarCpfCliente.Text;
            if(ClienteCpfBusca != null && ClienteCpfBusca != "")
            {
                IFachadaCliente fachada = new FachadaCliente();
                Projeto4_Junior.Modelo.Cliente cli = new Projeto4_Junior.Modelo.Cliente();

                cli = fachada.BuscarCliente(ClienteCpfBusca);
                if (cli.Nome != null)
                {
                    tbNomeCliente.Text = cli.Nome;
                    tbCpfCliente.Text = cli.Cpf;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Digite o CPF do cliente!");
            }
            
        }

        private void btAdicionarServico_Click(object sender, EventArgs e)
        {
            String buscarServico = cbServicos.Text;

            if (buscarServico != "")
            {
                buscarServico = (cbServicos.SelectedItem as Projeto4_Junior.Modelo.ComboboxItem).Value.ToString();
                IfachadaServico fachada = new FachadaServico();
                Projeto4_Junior.Modelo.Servico serv = fachada.BuscarServico(int.Parse(buscarServico));
                
                dGListaServProd.Rows.Add(serv.Descricao,serv.Valor,"Remover",0,serv.IdServico);
                this.valorTotal();
                //MessageBox.Show("" + buscarServico);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um serviço!");
            }
        }

        private void valorTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dGListaServProd.RowCount; i++)
            {
                decimal x = (decimal)dGListaServProd.Rows[i].Cells[1].Value;
                total += x;
            }
            if (total != 0) { 
                lbValorTotal.Text = ""+total;
            }
            else
            {
                lbValorTotal.Text = "00,00";
            }
        }

        private void dGListaServProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == dGListaServProd.Columns["remover"].Index)
            {
                this.dGListaServProd.Rows.Remove(this.dGListaServProd.CurrentRow);
                this.dGListaServProd.Refresh();
                this.valorTotal();
            }
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            String buscarProduto = cbProdutos.Text;

            if (buscarProduto != "")
            {
                buscarProduto = (cbProdutos.SelectedItem as Projeto4_Junior.Modelo.ComboboxItem).Value.ToString();
                IfachadaProduto fachada = new FachadaProduto();
                Projeto4_Junior.Modelo.Produto prod = fachada.BuscarProduto(int.Parse(buscarProduto));

                dGListaServProd.Rows.Add(prod.Descricao, prod.Valor, "Remover",prod.IdProduto,0);
                this.valorTotal();
                //MessageBox.Show("" + buscarServico);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um produto!");
            }
        }

        private void btFinalizarVenda_Click(object sender, EventArgs e)
        {
            //Validação dos campos
            String funcionario = (cbFuncionario.SelectedItem as Modelo.ComboboxItem).Value.ToString();
            String cliente = tbCpfCliente.Text;
            String total = lbValorTotal.Text;
           
            if (funcionario == "")
            {
                MessageBox.Show("Preencha o campo Funcionário!");
            }
            else if(cliente == "")
            {
                MessageBox.Show("Preencha o campo Cliente!");
            }
            else if (total == "00,00" || dGListaServProd.RowCount == 0)
            {
                MessageBox.Show("Deve ter algum item na venda!");
            }
            else
            {
               
                ifachadaVenda fachada = new FachadaVenda();
                Modelo.Venda venda = new Modelo.Venda();
                Modelo.ItensVenda item = new Modelo.ItensVenda();
                venda.CPFCliente = cliente;
                venda.CPFFuncionario = funcionario;
                venda.Data = DateTime.Now.ToString("dd/MM/yyyy");
                venda.ValorTotal = decimal.Parse(total);

                item.IdVenda = fachada.CadastrarVenda(venda);
                if (item.IdVenda != 0)
                {
                    for (int i = 0; i < dGListaServProd.RowCount; i++)
                    {
                        int idProduto = (int)dGListaServProd.Rows[i].Cells[3].Value;
                        int idServico = (int)dGListaServProd.Rows[i].Cells[4].Value;
                        if(idProduto != 0 ){
                            item.IdProduto = idProduto;
                            item.IdServico = 0;
                        }
                        if(idServico != 0){
                            item.IdServico = idServico;
                            item.IdProduto = 0;
                        }

                        fachada.CadastrarItensVenda(item);
                    }
                }
               
            }
        }
    }
}
