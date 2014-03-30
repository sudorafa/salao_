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
        public AlterarClientePrincipal()
        {
            InitializeComponent();
        }

        private void button_SalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            bool key = true;

            String[] campo = new String[12] { textBox_NomeCliente.Text, textBox_EmailCliente.Text, textBox_CpfCliente.Text
            , textBox_TelefoneCliente.Text, textBox_DataNascCliente.Text, textBox_EnderecoNumeroCliente.Text, textBox_EnderecoRuaCliente.Text
            , textBox_EnderecoComplementoCliente.Text, textBox_EnderecoBairroCliente.Text, textBox_EnderecoCidadeCliente.Text
            , textBox_EnderecoCepCliente.Text, comboBox_EnderecoUfCliente.Text};

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
                cliente.Endereco = campo[6] + " , ";
                cliente.Endereco = campo[7] + " , ";
                cliente.Endereco = campo[8] + " , ";
                cliente.Endereco = campo[9] + " , ";
                cliente.Endereco = campo[10] + " , ";
                cliente.Endereco = campo[11];

                fachadaCliente.AlterarCliente(cliente);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }          
        }

        public void PreencherCliente(String cpf)
        {
            textBox_CpfCliente.Text = cpf;
        }

        private void button_CancelarCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
