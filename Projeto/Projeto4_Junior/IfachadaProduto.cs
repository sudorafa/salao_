﻿using Projeto4_Junior.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior
{
    interface IfachadaProduto
    {
        void CadastrarProdutos(Produto produto);
        Produto BuscarProdutos(Produto produto);
        void RemoverProdutos(Produto produto);
        void AlterarProdutos(Produto produto);
        SqlDataReader VerificaProd(Produto produto);
        ArrayList ListarProduto(string produto);
    }
}
