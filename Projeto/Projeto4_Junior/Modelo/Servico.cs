using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Modelo
{
    public class Servico
    {
        public int IdServico { get; set; }
        public Boolean Ativo { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public int isGestor { get; set; }
        
        public Servico()
        {

        }
        public Servico(int idservico, Boolean ativo, String descricao, Decimal valor)
        {
            this.IdServico = idservico;
            this.Ativo = ativo;
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
