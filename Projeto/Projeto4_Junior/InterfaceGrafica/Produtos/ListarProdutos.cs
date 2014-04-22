﻿using Projeto4_Junior.Negocios;
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

namespace Projeto4_Junior.InterfaceGrafica.Produtos
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void BuscarProduto_Click(object sender, EventArgs e)
        {
            // LISTA OS FUNCIONARIO A PARTIR DO CAMPO DE BUSCA
            IfachadaProduto fachadaProduto = new FachadaProduto();
            ArrayList lista = fachadaProduto.ListarProduto(ProdutoBuscado.Text);
            //A função abaixo limpa o dataGridView, caso tenha uma nova busca
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Produto produto = new Projeto4_Junior.Modelo.Produto();
                produto = (Projeto4_Junior.Modelo.Produto)func;
                // PREENCHE AS COLUNAS DE 'NOME', 'CPF' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(produto.Descricao, produto.Valor, produto.Quantidade, "Remover", "Alterar");
            }
        }
    }
}