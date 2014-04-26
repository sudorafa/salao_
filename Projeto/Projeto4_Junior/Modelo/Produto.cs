﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class Produto
    {        
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public Boolean Ativo { get; set; }

        public Produto()
        {

        }
        public Produto(String nome, Decimal valor, int quantidade_estoque)
        {
            this.Descricao = nome;
            this.Valor = valor;
            this.Quantidade = quantidade_estoque;
        }
    }
}
