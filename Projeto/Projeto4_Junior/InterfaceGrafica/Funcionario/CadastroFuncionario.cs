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
            String msg = "";
           

            String[] campo = new String[12] {   tbNome.Text,                                                
                                                tbCpf.Text,
                                                tbTelefone.Text,
                                                tbDataNascimento.Text, 
                                                tbPorcentagem.Text,
                                                tbRuaEndereco.Text,
                                                tbNumeroEndereco.Text,
                                                tbComplementoEndereco.Text,
                                                tbBairroEndereco.Text,
                                                tbCepEndereco.Text,
                                                tbCidadeEndereco.Text,
                                                cbUfEndereco.Text};

            for (int x = 0; x < campo.Length; x++)
            {
                if (campo[x] == null || campo[x].Equals(""))
                {
                    key = false;
                    switch (x)
                    {
                        case 0:
                            msg = "Preencha o Nome!";
                            break;
                        case 1:
                            msg = "Preencha o CPF!";
                            break;
                        case 2:
                            msg = "Preencha o Telefone!";
                            break;
                        case 3:
                            msg = "Preencha a Data de Nascimento!";
                            break;
                        case 4:
                            msg = "Preencha a Porcentagem!";
                            break;
                        case 5:
                            msg = "Preencha a Rua!";
                            break;
                        case 6:
                            msg = "Preencha o Número!";
                            break;
                        case 7:
                            msg = "Preencha o Complemento!";
                            break;
                        case 8:
                            msg = "Preencha o Bairro!";
                            break;
                        case 9:
                            msg = "Preencha o CEP!";
                            break;
                        case 10:
                            msg = "Preencha a Cidade!";
                            break;
                        case 11:
                            msg = "Preencha o Estado!";
                            break;
                        

                    }
                    break;
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
                funcionario.Porcentagem = int.Parse(campo[4]);

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
                MessageBox.Show(msg);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
