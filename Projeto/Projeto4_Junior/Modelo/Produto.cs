using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    class Produto
    {        
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
<<<<<<< HEAD
        public int Quantidade_Estoque { get; set; }
=======
        public int Quantidade { get; set; }
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
        public int IdProduto { get; set; }
        public Boolean Ativo { get; set; }

        public Produto()
        {

        }
        public Produto(String nome, Decimal valor, int quantidade_estoque)
        {
            this.Descricao = nome;
            this.Valor = valor;
<<<<<<< HEAD
            this.Quantidade_Estoque = quantidade_estoque;
=======
            this.Quantidade = quantidade_estoque;
>>>>>>> 66f00740a17d1a8df448f010c5eeb1f9f829d430
        }
    }
}
