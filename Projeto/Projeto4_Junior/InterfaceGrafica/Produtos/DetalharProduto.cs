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
    public partial class DetalharProduto : Form
    {
        public DetalharProduto()
        {
            InitializeComponent();
        }

        public DetalharProduto(Projeto4_Junior.Modelo.Produto produto)
        {
            InitializeComponent();
            DescricaoProduto.Text = produto.Descricao;
            ValorProduto.Text = Convert.ToString(produto.Valor);
            QuantidadeProduto.Text = Convert.ToString(produto.Quantidade);

        }

        private void DetalharProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
