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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            IfachadaProduto fachadaProduto = new FachadaProduto();
            Produto umProduto = new Produto();
 
            if(DescricaoProduto.Text.Equals("") || DescricaoProduto == null ||
               ValorProduto.Equals("") || ValorProduto == null ||
               QuantidadeProduto.Equals("") || QuantidadeProduto == null)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                umProduto.Descricao = DescricaoProduto.Text;
                umProduto.Valor = Decimal.Parse(ValorProduto.Text);
                umProduto.Quantidade = int.Parse(QuantidadeProduto.Text);
                umProduto.Ativo = true;

                fachadaProduto.CadastrarProdutos(umProduto);
                this.Close();
            }
        }
    }
}
