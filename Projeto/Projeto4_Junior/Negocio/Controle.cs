using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.DOA;

namespace Projeto4_Junior.Negocio
{
    class Controle:IControle
    {
        public Controle()
        {

        }
        private static IBanco banco = new BD();
        public DataTable busca()
        {
            banco.busca();
        }
    }
}
