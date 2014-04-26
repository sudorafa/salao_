using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    public partial class AlterarServico : Form
    {
        public AlterarServico(Projeto4_Junior.Modelo.Servico serv, ListarServico listarServ)
        {
            InitializeComponent();
            tbNome.Text = serv.Descricao;
            tbValor.Double = serv.Valor;

            this.listar = listarServ;
        }
        public AlterarServico()
        {
             InitializeComponent();
        }
         private ListarServico listar { get; set; }

        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AlterarServico_Load(object sender, EventArgs e)
        {
        
        }
    }
}
