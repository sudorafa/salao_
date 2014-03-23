using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    class Servico
    {
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }   

        public Servico()
        {

        }
        public Servico(String nome, Decimal valor)
        {
            this.Descricao = nome;
            this.Valor = valor;            
        }
    }
}
