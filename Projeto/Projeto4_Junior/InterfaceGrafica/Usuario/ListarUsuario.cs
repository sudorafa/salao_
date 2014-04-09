using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Usuario
{
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void BuscarListaUsuario_Click(object sender, EventArgs e)
        {
            //parei aqui!!!
            
            IfachadaUsuario ifachada = new FachadaUsuario();

            ifachada.ListarUsuario(Usuario_Buscado.Text);
        }
    }
}
