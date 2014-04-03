using Projeto4_Junior.Negocios;
using Projeto4_Junior.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool key = true;

            String[] campo = new String[12] {   tbNome.Text,
                                                tbTelefone.Text,
                                                tbCpf.Text,
                                                tbDataNascimento.Text, 
                                                tbPorcentagem.Text,
                                                tbNumeroEndereco.Text,
                                                tbRuaEndereco.Text,
                                                tbComplementoEndereco.Text,
                                                tbBairroEndereco.Text,
                                                tbCidadeEndereco.Text,
                                                cbUfEndereco.Text,
                                                tbCepEndereco.Text};

            for (int x = 0; x < campo.Length; x++)
            {
                if (campo[x] == null || campo[x].Equals(""))
                {
                    key = false;
                }
            }

            if (key == true)
            {
                IfachadaFuncionario fachadaFuncionario = new FachadaFuncionario();
                Projeto4_Junior.Modelo.Funcionario funcionario = new Projeto4_Junior.Modelo.Funcionario();

                funcionario.Nome = campo[0];
                funcionario.Telefone = campo[1];
                funcionario.Cpf = campo[2];
                funcionario.Data_Nascimento = campo[3];
                funcionario.Porcentagem = Double.Parse(campo[4]);

                funcionario.Endereco = campo[5] + " , ";
                funcionario.Endereco += campo[6] + " , ";
                funcionario.Endereco += campo[7] + " , ";
                funcionario.Endereco += campo[8] + " , ";
                funcionario.Endereco += campo[9] + " , ";
                funcionario.Endereco += campo[10] + " , ";
                funcionario.Endereco += campo[11] ;


                fachadaFuncionario.CadastrarFuncionario(funcionario);
                this.Close();
             
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
