﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto4_Junior.Negocios
{
    class ControladorProduto : IfachadaProduto
    {
        private IBancoDadosProduto ibancodados = new BancoDadosProduto();
        public void CadastrarProdutos(Produto produto)
        {           
            this.ibancodados.CadastrarProdutos(produto);           
        }
        public Produto BuscarProdutos(Produto produto)
        {
            return null;
        }
        public void RemoverProdutos(Produto produto)
        {
            
        }
        public void AlterarProdutos(Produto produto)
        {
          
        }
        public SqlDataReader VerificaProd(Produto produto)
        {
            return this.ibancodados.VerificaProd(produto);  
        }
    }
}
