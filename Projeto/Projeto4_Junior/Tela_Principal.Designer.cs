namespace Projeto4_Junior
{
    partial class Form_Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.clientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServicoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarServicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarServicoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerServicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancoDiarioRelatorioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosRelatoriosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioServicosPorClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioServicosPorFuncionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioConvenieciaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioEstoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaEstoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaEstoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenuItem,
            this.funcionariosMenuItem,
            this.servicosMenuItem,
            this.relatoriosMenuItem,
            this.estoqueMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu_principal.Size = new System.Drawing.Size(719, 28);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "MenuPrincipal";
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteMenuItem,
            this.alterarClienteMenuItem,
            this.listarClienteMenuItem,
            this.removerClienteMenuItem,
            this.aniversariantesClienteMenuItem});
            this.clientesMenuItem.Name = "clientesMenuItem";
            this.clientesMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesMenuItem.Text = "&Clientes";
            // 
            // inserirClienteMenuItem
            // 
            this.inserirClienteMenuItem.Name = "inserirClienteMenuItem";
            this.inserirClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.inserirClienteMenuItem.Text = "Inserir";
            this.inserirClienteMenuItem.Click += new System.EventHandler(this.inserirClienteMenuItem_Click);
            // 
            // alterarClienteMenuItem
            // 
            this.alterarClienteMenuItem.Name = "alterarClienteMenuItem";
            this.alterarClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.alterarClienteMenuItem.Text = "Alterar";
            this.alterarClienteMenuItem.Click += new System.EventHandler(this.alterarClienteMenuItem_Click);
            // 
            // listarClienteMenuItem
            // 
            this.listarClienteMenuItem.Name = "listarClienteMenuItem";
            this.listarClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.listarClienteMenuItem.Text = "Listar";
            this.listarClienteMenuItem.Click += new System.EventHandler(this.listarClienteMenuItem_Click);
            // 
            // removerClienteMenuItem
            // 
            this.removerClienteMenuItem.Name = "removerClienteMenuItem";
            this.removerClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.removerClienteMenuItem.Text = "Remover";
            this.removerClienteMenuItem.Click += new System.EventHandler(this.removerClienteMenuItem_Click);
            // 
            // aniversariantesClienteMenuItem
            // 
            this.aniversariantesClienteMenuItem.Name = "aniversariantesClienteMenuItem";
            this.aniversariantesClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.aniversariantesClienteMenuItem.Text = "Aniversariantes";
            // 
            // funcionariosMenuItem
            // 
            this.funcionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirFuncionarioMenuItem,
            this.alterarFuncionarioMenuItem,
            this.listarFuncionarioMenuItem,
            this.removerFuncionarioMenuItem});
            this.funcionariosMenuItem.Name = "funcionariosMenuItem";
            this.funcionariosMenuItem.Size = new System.Drawing.Size(104, 24);
            this.funcionariosMenuItem.Text = "&Funcionários";
            // 
            // inserirFuncionarioMenuItem
            // 
            this.inserirFuncionarioMenuItem.Name = "inserirFuncionarioMenuItem";
            this.inserirFuncionarioMenuItem.Size = new System.Drawing.Size(152, 24);
            this.inserirFuncionarioMenuItem.Text = "Inserir";
            // 
            // alterarFuncionarioMenuItem
            // 
            this.alterarFuncionarioMenuItem.Name = "alterarFuncionarioMenuItem";
            this.alterarFuncionarioMenuItem.Size = new System.Drawing.Size(152, 24);
            this.alterarFuncionarioMenuItem.Text = "Alterar";
            // 
            // listarFuncionarioMenuItem
            // 
            this.listarFuncionarioMenuItem.Name = "listarFuncionarioMenuItem";
            this.listarFuncionarioMenuItem.Size = new System.Drawing.Size(152, 24);
            this.listarFuncionarioMenuItem.Text = "Listar";
            // 
            // removerFuncionarioMenuItem
            // 
            this.removerFuncionarioMenuItem.Name = "removerFuncionarioMenuItem";
            this.removerFuncionarioMenuItem.Size = new System.Drawing.Size(152, 24);
            this.removerFuncionarioMenuItem.Text = "Remover";
            // 
            // servicosMenuItem
            // 
            this.servicosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoServicoMenuItem,
            this.alterarServicoToolStripMenuItem,
            this.listarServicoMenuItem,
            this.removerServicoToolStripMenuItem});
            this.servicosMenuItem.Name = "servicosMenuItem";
            this.servicosMenuItem.Size = new System.Drawing.Size(75, 24);
            this.servicosMenuItem.Text = "&Serviços";
            // 
            // novoServicoMenuItem
            // 
            this.novoServicoMenuItem.Name = "novoServicoMenuItem";
            this.novoServicoMenuItem.Size = new System.Drawing.Size(187, 24);
            this.novoServicoMenuItem.Text = "Novo serviço";
            // 
            // alterarServicoToolStripMenuItem
            // 
            this.alterarServicoToolStripMenuItem.Name = "alterarServicoToolStripMenuItem";
            this.alterarServicoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.alterarServicoToolStripMenuItem.Text = "Alterar serviço";
            // 
            // listarServicoMenuItem
            // 
            this.listarServicoMenuItem.Name = "listarServicoMenuItem";
            this.listarServicoMenuItem.Size = new System.Drawing.Size(187, 24);
            this.listarServicoMenuItem.Text = "Listar serviços";
            // 
            // removerServicoToolStripMenuItem
            // 
            this.removerServicoToolStripMenuItem.Name = "removerServicoToolStripMenuItem";
            this.removerServicoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.removerServicoToolStripMenuItem.Text = "Remover serviço";
            // 
            // relatoriosMenuItem
            // 
            this.relatoriosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balancoDiarioRelatorioMenuItem,
            this.servicosRelatoriosMenuItem,
            this.relatorioConvenieciaMenuItem,
            this.relatorioEstoqueMenuItem});
            this.relatoriosMenuItem.Name = "relatoriosMenuItem";
            this.relatoriosMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatoriosMenuItem.Text = "&Relatórios";
            // 
            // balancoDiarioRelatorioMenuItem
            // 
            this.balancoDiarioRelatorioMenuItem.Name = "balancoDiarioRelatorioMenuItem";
            this.balancoDiarioRelatorioMenuItem.Size = new System.Drawing.Size(174, 24);
            this.balancoDiarioRelatorioMenuItem.Text = "Balanço diário";
            // 
            // servicosRelatoriosMenuItem
            // 
            this.servicosRelatoriosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioServicosPorClienteMenuItem,
            this.relatorioServicosPorFuncionariosMenuItem});
            this.servicosRelatoriosMenuItem.Name = "servicosRelatoriosMenuItem";
            this.servicosRelatoriosMenuItem.Size = new System.Drawing.Size(174, 24);
            this.servicosRelatoriosMenuItem.Text = "Serviços";
            // 
            // relatorioServicosPorClienteMenuItem
            // 
            this.relatorioServicosPorClienteMenuItem.Name = "relatorioServicosPorClienteMenuItem";
            this.relatorioServicosPorClienteMenuItem.Size = new System.Drawing.Size(179, 24);
            this.relatorioServicosPorClienteMenuItem.Text = "Por cliente";
            // 
            // relatorioServicosPorFuncionariosMenuItem
            // 
            this.relatorioServicosPorFuncionariosMenuItem.Name = "relatorioServicosPorFuncionariosMenuItem";
            this.relatorioServicosPorFuncionariosMenuItem.Size = new System.Drawing.Size(179, 24);
            this.relatorioServicosPorFuncionariosMenuItem.Text = "Por funcionário";
            // 
            // relatorioConvenieciaMenuItem
            // 
            this.relatorioConvenieciaMenuItem.Name = "relatorioConvenieciaMenuItem";
            this.relatorioConvenieciaMenuItem.Size = new System.Drawing.Size(174, 24);
            this.relatorioConvenieciaMenuItem.Text = "Conveniêcia";
            // 
            // relatorioEstoqueMenuItem
            // 
            this.relatorioEstoqueMenuItem.Name = "relatorioEstoqueMenuItem";
            this.relatorioEstoqueMenuItem.Size = new System.Drawing.Size(174, 24);
            this.relatorioEstoqueMenuItem.Text = "Estoque";
            // 
            // estoqueMenuItem
            // 
            this.estoqueMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaEstoqueMenuItem,
            this.saidaEstoqueMenuItem});
            this.estoqueMenuItem.Name = "estoqueMenuItem";
            this.estoqueMenuItem.Size = new System.Drawing.Size(74, 24);
            this.estoqueMenuItem.Text = "&Estoque";
            // 
            // entradaEstoqueMenuItem
            // 
            this.entradaEstoqueMenuItem.Name = "entradaEstoqueMenuItem";
            this.entradaEstoqueMenuItem.Size = new System.Drawing.Size(152, 24);
            this.entradaEstoqueMenuItem.Text = "Entradas";
            // 
            // saidaEstoqueMenuItem
            // 
            this.saidaEstoqueMenuItem.Name = "saidaEstoqueMenuItem";
            this.saidaEstoqueMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saidaEstoqueMenuItem.Text = "Saídas";
            // 
            // Form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 381);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Index";
            this.Text = "ArBelSys - Index";
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem clientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServicoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarServicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarServicoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerServicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancoDiarioRelatorioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosRelatoriosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioServicosPorClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioServicosPorFuncionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioConvenieciaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioEstoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaEstoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaEstoqueMenuItem;
    }
}