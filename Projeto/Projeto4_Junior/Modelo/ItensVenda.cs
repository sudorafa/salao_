using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class ItensVenda
    {
        public int IdVenda { get; set; }
        public int IdServico { get; set; }
        public int IdProduto { get; set; }


        public ItensVenda()
        {

        }
        public ItensVenda(int idVenda, int idServico, int idProduto)
        {
            this.IdVenda = idVenda;
            this.IdServico = idServico;
            this.IdProduto = IdProduto;
        }
    }
}
