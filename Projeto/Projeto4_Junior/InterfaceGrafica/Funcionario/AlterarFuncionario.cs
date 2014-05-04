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

namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    public partial class AlterarFuncionario : Form
    {
        public AlterarFuncionario(Projeto4_Junior.Modelo.Funcionario func, ListarFuncionario listarFunc)
        {
            InitializeComponent();

            tbNome.Text = func.Nome;
            tbTelefone.Text = func.Telefone;
            tbCpf.Text = func.Cpf;
            tbDataNascimento.Text = func.DataNascimento;
            tbPorcentagem.Text = ""+func.Porcentagem;

            this.listar = listarFunc;

        }
        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private ListarFuncionario listar { get; set; }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
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
           

            String[] campo = new String[5] {   tbNome.Text,                                                
                                                tbCpf.Text,
                                                tbTelefone.Text,
                                                tbDataNascimento.Text, 
                                                tbPorcentagem.Text};

            String[] campoEndereco = new String[7]{ tbRuaEndereco.Text,
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
                        
                    }
                    break;
                 }
            }
             


            if (key == true)
            {

                for (int x = 0; x < campoEndereco.Length; x++)
                {
                    if (campoEndereco[x] == null || campoEndereco.Equals(""))
                    {
                        key = false;
                        MessageBox.Show("Preencha todos os campos do endereço!");

                     }
                        break;
                }

                if (key == true)
                {

                    IfachadaFuncionario fachadaFuncionario = new FachadaFuncionario();
                    Projeto4_Junior.Modelo.Funcionario funcionario = new Projeto4_Junior.Modelo.Funcionario();

                    funcionario.Nome = campo[0];
                    funcionario.Cpf = campo[1];
                    funcionario.Telefone = campo[2];
                    funcionario.DataNascimento = campo[3];
                    funcionario.Porcentagem = int.Parse(campo[4]);

                    funcionario.Endereco = campoEndereco[0] + ", ";
                    funcionario.Endereco += campoEndereco[1] + ", ";
                    funcionario.Endereco += campoEndereco[2] + ", ";
                    funcionario.Endereco += campoEndereco[3] + ", ";
                    funcionario.Endereco += campoEndereco[4] + ", ";
                    funcionario.Endereco += campoEndereco[5] + ", ";
                    funcionario.Endereco += campoEndereco[6];

                    fachadaFuncionario.AlterarFuncionario(funcionario);
                    listar.dataGridView1.Rows.Clear();
                    listar.btBurcarFuncionario_Click(sender, e);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
