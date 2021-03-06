﻿using Projeto4_Junior.Banco;
using Projeto4_Junior.InterfaceGrafica.Caixa;
using Projeto4_Junior.InterfaceGrafica.Funcionario;
using Projeto4_Junior.InterfaceGrafica.Produtos;
using Projeto4_Junior.InterfaceGrafica.Servicos;
using Projeto4_Junior.InterfaceGrafica.Usuario;
using Projeto4_Junior.Modelo;
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

namespace Projeto4_Junior
{
    public partial class Form_Index : Form
    {
        bool gestor;
        public Form_Index(bool gestor)
        {
            this.gestor = gestor; 
            InitializeComponent();
        }

        public Form_Index()
        {
            InitializeComponent();
        }

        
        private void inserirClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroClientes cad_cli = new Form_CadastroClientes();
            cad_cli.ShowDialog();
        }

        private void alterarClienteMenuItem_Click(object sender, EventArgs e)
        {
            //Form_AlterarCliente alt_cli = new Form_AlterarCliente();
            //alt_cli.ShowDialog();
        }

        private void listarClienteMenuItem_Click(object sender, EventArgs e)
        {
            ListarCliente list_cli = new ListarCliente();
            list_cli.ShowDialog();
        }

        private void removerClienteMenuItem_Click(object sender, EventArgs e)
        {
            //Form_RemoverCliente remov_cli = new Form_RemoverCliente();
            //remov_cli.ShowDialog();
        }

        private void button_CadastrarClienteBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            Form_CadastroClientes cad_cli = new Form_CadastroClientes();
            cad_cli.ShowDialog();
        }

        private void Form_Index_Load(object sender, EventArgs e)
        {
            

            if (gestor == false)
            {
               this.funcionariosMenuItem.Enabled = false;
               this.servicosMenuItem.Enabled = false;
               //this.relatoriosMenuItem.Enabled = false;
               this.estoqueMenuItem.Enabled = false;
               this.usuariosMenuItem.Enabled = false;
               this.button_InserirFuncionarioBarraDeFerramentas.Enabled = false;
               this.button_InserirServicoBarraDeFerramentas.Enabled = false;
               //this.button_RelatorioDiarioBarraDeFerramentas.Enabled = false;
               //this.button_RelatorioEstoqueBarraDeFerramentas.Enabled = false;
               this.button_InserirUsuarioBarraDeFerramentas.Enabled = false;                
            }
              
        }

        private void inserirUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cad_usu = new CadastrarUsuario();
            cad_usu.ShowDialog();
        }

        private void inserirFuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cad_func = new CadastroFuncionario();
            cad_func.ShowDialog();

        }

        private void menu_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_SairBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            Autenticacao aut = new Autenticacao();
            aut.Show();
            this.Close();
        }

        private void listarFuncionariosMenuItem_Click(object sender, EventArgs e)
        {
            ListarFuncionario tela = new ListarFuncionario();
            tela.ShowDialog();
        }

        private void listarUsuariosMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuario usuario = new ListarUsuario();
            usuario.ShowDialog();
        }

        private void novoServicoMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCadastrarServico formularioCadastrarServico = new FormularioCadastrarServico();
            formularioCadastrarServico.ShowDialog();
        }

        private void alterarServicoMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senhor usuario(a) a opção de ALTERAR estar disponivel somente na opção LISTAR ");//quando listar um serviço, vai ter a opção de alterar
        }

        private void removerServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senhor usuario(a) a opção de REMOVER estar disponivel somente na opção LISTAR ");//quando listar um serviço, vai ter a opção de remover um serviço.
        }

        private void listarServicosMenuItem_Click(object sender, EventArgs e)
        {
            FormularioListarServico formularioListarServico = new FormularioListarServico();
            formularioListarServico.ShowDialog();
        }

        private void button_InserirFuncionarioBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cad_func = new CadastroFuncionario();
            cad_func.ShowDialog();
        }

        private void entradaEstoqueMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto tela = new CadastroProduto();
            tela.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProdutos tela = new ListarProdutos();
            tela.Show();
        }

        private void button_AbriCaixa_Click(object sender, EventArgs e)
        {
            TelaAbrirCaixa telaCaixa = new TelaAbrirCaixa();
            telaCaixa.ShowDialog();
        }

        private void sairMenuItem_Click(object sender, EventArgs e)
        {
            Autenticacao aut = new Autenticacao();
            aut.Show();
            this.Close();
        }

        private void button_InserirServicoBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            FormularioCadastrarServico formularioCadastrarServico = new FormularioCadastrarServico();
            formularioCadastrarServico.ShowDialog();
        }

        private void button_InserirUsuarioBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cad_usu = new CadastrarUsuario();
            cad_usu.ShowDialog();
        }

        private void alterarCadastroMeuUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            IfachadaUsuario fachadausuario = new FachadaUsuario();
            Usuario usu = fachadausuario.BuscarUsuario(SessionUser.login);
            
            AlterarUsuario tela = new AlterarUsuario(usu);
            tela.ShowDialog();
        }

        private void alterarLoginSenhaMeuUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            IfachadaUsuario fachadausuario = new FachadaUsuario();
            Usuario usu = fachadausuario.BuscarUsuario(SessionUser.login);

            AlterarLoginSenha tela = new AlterarLoginSenha(usu);
            tela.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            IfachadaUsuario fachadausuario = new FachadaUsuario();
            Usuario usu = fachadausuario.BuscarUsuario(SessionUser.login);

            AlterarLoginSenha tela = new AlterarLoginSenha(usu);
            tela.ShowDialog();
        }

        private void aniversariantesClienteMenuItem_Click(object sender, EventArgs e)
        {
            Projeto4_Junior.InterfaceGrafica.Cliente.Aniversariantes tela =
               new Projeto4_Junior.InterfaceGrafica.Cliente.Aniversariantes();

            tela.Show();
        }

        private void button_RelatorioDiarioBarraDeFerramentas_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersistenciaVenda v = new PersistenciaVenda();
            v.RelatorioBalacoDiario();
            MessageBox.Show("Relatório gerado com sucesso! LOCAL DO ARQUIVO DISCO C.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
