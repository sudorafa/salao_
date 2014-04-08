using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;

namespace Projeto4_Junior
{
    public partial class AlterarClientePrincipal : Form
    {
        public AlterarClientePrincipal(Cliente cli, ListarCliente list)
        {
            InitializeComponent();

            textBox_NomeCliente.Text = cli.Nome;
            textBox_EmailCliente.Text = cli.Email;
            textBox_CpfCliente.Text = cli.Cpf;
            textBox_TelefoneCliente.Text = cli.Telefone;
            textBox_DataNascCliente.Text = cli.Data_Nascimento;

            this.listar = list;

           
        }
        private ListarCliente listar { get; set; }

        public AlterarClientePrincipal()
        {
            InitializeComponent();
        }

       

        public void PreencherCliente(String cpf)
        {
            textBox_CpfCliente.Text = cpf;
        }

        

        private void AlterarClientePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button_SalvarCadastroCliente_Click_1(object sender, EventArgs e)
        {
            bool key = true;

            String[] campo = new String[12] {      textBox_NomeCliente.Text, 
                                                   textBox_EmailCliente.Text, 
                                                   textBox_CpfCliente.Text, 
                                                   textBox_TelefoneCliente.Text, 
                                                   textBox_DataNascCliente.Text, 
                                                   textBox_EnderecoNumeroCliente.Text, 
                                                   textBox_EnderecoRuaCliente.Text, 
                                                   textBox_EnderecoComplementoCliente.Text, 
                                                   textBox_EnderecoBairroCliente.Text, 
                                                   textBox_EnderecoCidadeCliente.Text, 
                                                   textBox_EnderecoCepCliente.Text, 
                                                   comboBox_EnderecoUfCliente.Text};

            for (int x = 0; x < campo.Length; x++)
            {
                if (campo[x] == null || campo[x].Equals(""))
                {
                    key = false;
                }
            }

            if (key == true)
            {
                IFachadaCliente fachadaCliente = new FachadaCliente();
                Cliente cliente = new Cliente();

                cliente.Nome = campo[0];
                cliente.Email = campo[1];
                cliente.Cpf = campo[2];
                cliente.Telefone = campo[3];
                cliente.Data_Nascimento = campo[4];
                cliente.Endereco = campo[5] + " , ";
                cliente.Endereco += campo[6] + " , ";
                cliente.Endereco += campo[7] + " , ";
                cliente.Endereco += campo[8] + " , ";
                cliente.Endereco += campo[9] + " , ";
                cliente.Endereco += campo[10] + " , ";
                cliente.Endereco += campo[11];

                fachadaCliente.AlterarCliente(cliente);
                listar.dataGridView1.Rows.Clear();
                listar.BuscarListaCliente_Click(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            } 
        }

        private void button_CancelarCadastroCliente_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
