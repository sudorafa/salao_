using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public Decimal ValorTotal { get; set; }
        public String CPFFuncionario { get; set; }
        public String CPFCliente { get; set; }
        public DateTime Data { get; set; }


        public Venda()
        {

        }
        public Venda(int idVenda, Decimal ValorTotal,String CPFFuncionario, String CPFCliente, DateTime Data)
        {
            this.IdVenda = idVenda;
            this.ValorTotal = ValorTotal;
            this.CPFFuncionario = CPFFuncionario;
            this.CPFCliente = CPFCliente;
            this.Data = Data;

        }

    }
}
