using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
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
    public partial class AlterarProduto : Form
    {        
        int idProdutoParaAlterar;
        private Produto prod;
        private ListarProdutos listarProdutos;

        public AlterarProduto()
        {
            InitializeComponent();
        }
        public AlterarProduto(Produto prod, ListarProdutos listarProdutos)
        {
            InitializeComponent();

            DescricaoPro.Text = prod.Descricao;
            ValorProd.Text = Convert.ToString(prod.Valor);
            QuantidadeProd.Text = Convert.ToString(prod.Quantidade);
            this.idProdutoParaAlterar = prod.IdProduto;

            this.prod = prod;
            this.listarProdutos = listarProdutos;
        }
        private void AlterarProduto_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            IfachadaProduto fachada = new FachadaProduto();
            Projeto4_Junior.Modelo.Produto produto = new Projeto4_Junior.Modelo.Produto();

            if(DescricaoPro.Text == null || DescricaoPro.Text.Equals("") ||
               ValorProd.Text == null || ValorProd.Text.Equals("") ||
                QuantidadeProd.Text == null || QuantidadeProd.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                produto.Descricao = DescricaoPro.Text;
                produto.Valor = Convert.ToDecimal(ValorProd.Text);
                produto.Quantidade = Convert.ToInt32(QuantidadeProd.Text);
                produto.IdProduto = idProdutoParaAlterar;

                fachada.AlterarProduto(produto);
                this.Close();
            }
        }
    }
}
