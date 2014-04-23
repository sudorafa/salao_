using System;
using Projeto4_Junior.Negocios;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    public partial class FormularioListarServico : Form
    {
        public FormularioListarServico()
        {
            InitializeComponent();
        }

        private void BuscarListaServico_Click(object sender, EventArgs e)
        {
            IfachadaServico fachadaservico = new FachadaServico();
            ArrayList lista = fachadaservico.ListarServico(Servico_Buscado.Text);
            dataGridView1.Rows.Clear();
            foreach (var func in lista)
            {
                Projeto4_Junior.Modelo.Servico servico = new Projeto4_Junior.Modelo.Servico();
                servico = (Projeto4_Junior.Modelo.Servico)func;
                // PREENCHE AS COLUNAS DE 'Nome', 'Login' E O NOMES DOS BOTÕES PADRÕES
                dataGridView1.Rows.Add(servico.Descricao, servico.Valor, "Remover", "Alterar");
            }
        }
    }
}
