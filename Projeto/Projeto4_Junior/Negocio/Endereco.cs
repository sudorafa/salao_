using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Negocio
{
    abstract class Endereco
    {
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Complemento  { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }

    }
}
