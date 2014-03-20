using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior
{
    public partial class Form_ListarClientes : Form
    {
        public Form_ListarClientes()
        {
            InitializeComponent();
        }

        private void button_CancelarLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
