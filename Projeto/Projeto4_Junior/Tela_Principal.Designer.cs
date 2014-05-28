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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Index));
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.clientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServicoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarServicosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaEstoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaEstoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCadastroMeuUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLoginSenhaMeuUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeFerramentas = new System.Windows.Forms.ToolStrip();
            this.button_InserirClienteBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.button_AniversariantesBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.button_InserirFuncionarioBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.button_InserirServicoBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.button_InserirUsuarioBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button_AbriCaixa = new System.Windows.Forms.ToolStripButton();
            this.button_SairBarraDeFerramentas = new System.Windows.Forms.ToolStripButton();
            this.menu_principal.SuspendLayout();
            this.barraDeFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenuItem,
            this.funcionariosMenuItem,
            this.servicosMenuItem,
            this.estoqueMenuItem,
            this.usuariosMenuItem,
            this.meuUsuarioMenuItem,
            this.sairMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu_principal.Size = new System.Drawing.Size(749, 28);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "MenuPrincipal";
            this.menu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_principal_ItemClicked);
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteMenuItem,
            this.listarClientesMenuItem,
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
            // listarClientesMenuItem
            // 
            this.listarClientesMenuItem.Name = "listarClientesMenuItem";
            this.listarClientesMenuItem.Size = new System.Drawing.Size(178, 24);
            this.listarClientesMenuItem.Text = "Listar";
            this.listarClientesMenuItem.Click += new System.EventHandler(this.listarClienteMenuItem_Click);
            // 
            // aniversariantesClienteMenuItem
            // 
            this.aniversariantesClienteMenuItem.Name = "aniversariantesClienteMenuItem";
            this.aniversariantesClienteMenuItem.Size = new System.Drawing.Size(178, 24);
            this.aniversariantesClienteMenuItem.Text = "Aniversariantes";
            this.aniversariantesClienteMenuItem.Click += new System.EventHandler(this.aniversariantesClienteMenuItem_Click);
            // 
            // funcionariosMenuItem
            // 
            this.funcionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirFuncionarioMenuItem,
            this.listarFuncionariosMenuItem});
            this.funcionariosMenuItem.Name = "funcionariosMenuItem";
            this.funcionariosMenuItem.Size = new System.Drawing.Size(104, 24);
            this.funcionariosMenuItem.Text = "&Funcionários";
            // 
            // inserirFuncionarioMenuItem
            // 
            this.inserirFuncionarioMenuItem.Name = "inserirFuncionarioMenuItem";
            this.inserirFuncionarioMenuItem.Size = new System.Drawing.Size(118, 24);
            this.inserirFuncionarioMenuItem.Text = "Inserir";
            this.inserirFuncionarioMenuItem.Click += new System.EventHandler(this.inserirFuncionarioMenuItem_Click);
            // 
            // listarFuncionariosMenuItem
            // 
            this.listarFuncionariosMenuItem.Name = "listarFuncionariosMenuItem";
            this.listarFuncionariosMenuItem.Size = new System.Drawing.Size(118, 24);
            this.listarFuncionariosMenuItem.Text = "Listar";
            this.listarFuncionariosMenuItem.Click += new System.EventHandler(this.listarFuncionariosMenuItem_Click);
            // 
            // servicosMenuItem
            // 
            this.servicosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoServicoMenuItem,
            this.listarServicosMenuItem});
            this.servicosMenuItem.Name = "servicosMenuItem";
            this.servicosMenuItem.Size = new System.Drawing.Size(75, 24);
            this.servicosMenuItem.Text = "Se&rviços";
            // 
            // novoServicoMenuItem
            // 
            this.novoServicoMenuItem.Name = "novoServicoMenuItem";
            this.novoServicoMenuItem.Size = new System.Drawing.Size(169, 24);
            this.novoServicoMenuItem.Text = "Novo serviço";
            this.novoServicoMenuItem.Click += new System.EventHandler(this.novoServicoMenuItem_Click);
            // 
            // listarServicosMenuItem
            // 
            this.listarServicosMenuItem.Name = "listarServicosMenuItem";
            this.listarServicosMenuItem.Size = new System.Drawing.Size(169, 24);
            this.listarServicosMenuItem.Text = "Listar serviços";
            this.listarServicosMenuItem.Click += new System.EventHandler(this.listarServicosMenuItem_Click);
            // 
            // estoqueMenuItem
            // 
            this.estoqueMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaEstoqueMenuItem,
            this.saidaEstoqueMenuItem,
            this.listarToolStripMenuItem});
            this.estoqueMenuItem.Name = "estoqueMenuItem";
            this.estoqueMenuItem.Size = new System.Drawing.Size(74, 24);
            this.estoqueMenuItem.Text = "&Estoque";
            // 
            // entradaEstoqueMenuItem
            // 
            this.entradaEstoqueMenuItem.Name = "entradaEstoqueMenuItem";
            this.entradaEstoqueMenuItem.Size = new System.Drawing.Size(152, 24);
            this.entradaEstoqueMenuItem.Text = "Entradas";
            this.entradaEstoqueMenuItem.Click += new System.EventHandler(this.entradaEstoqueMenuItem_Click);
            // 
            // saidaEstoqueMenuItem
            // 
            this.saidaEstoqueMenuItem.Name = "saidaEstoqueMenuItem";
            this.saidaEstoqueMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saidaEstoqueMenuItem.Text = "Saídas";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // usuariosMenuItem
            // 
            this.usuariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirUsuarioMenuItem,
            this.listarUsuariosMenuItem});
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosMenuItem.Text = "&Usuários";
            // 
            // inserirUsuarioMenuItem
            // 
            this.inserirUsuarioMenuItem.Name = "inserirUsuarioMenuItem";
            this.inserirUsuarioMenuItem.Size = new System.Drawing.Size(152, 24);
            this.inserirUsuarioMenuItem.Text = "Inserir";
            this.inserirUsuarioMenuItem.Click += new System.EventHandler(this.inserirUsuarioMenuItem_Click);
            // 
            // listarUsuariosMenuItem
            // 
            this.listarUsuariosMenuItem.Name = "listarUsuariosMenuItem";
            this.listarUsuariosMenuItem.Size = new System.Drawing.Size(152, 24);
            this.listarUsuariosMenuItem.Text = "Listar";
            this.listarUsuariosMenuItem.Click += new System.EventHandler(this.listarUsuariosMenuItem_Click);
            // 
            // meuUsuarioMenuItem
            // 
            this.meuUsuarioMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarCadastroMeuUsuarioMenuItem,
            this.alterarLoginSenhaMeuUsuarioMenuItem});
            this.meuUsuarioMenuItem.Name = "meuUsuarioMenuItem";
            this.meuUsuarioMenuItem.Size = new System.Drawing.Size(104, 24);
            this.meuUsuarioMenuItem.Text = "&Meu Usuário";
            // 
            // alterarCadastroMeuUsuarioMenuItem
            // 
            this.alterarCadastroMeuUsuarioMenuItem.Name = "alterarCadastroMeuUsuarioMenuItem";
            this.alterarCadastroMeuUsuarioMenuItem.Size = new System.Drawing.Size(219, 24);
            this.alterarCadastroMeuUsuarioMenuItem.Text = "Alterar cadastro";
            this.alterarCadastroMeuUsuarioMenuItem.Click += new System.EventHandler(this.alterarCadastroMeuUsuarioMenuItem_Click);
            // 
            // alterarLoginSenhaMeuUsuarioMenuItem
            // 
            this.alterarLoginSenhaMeuUsuarioMenuItem.Name = "alterarLoginSenhaMeuUsuarioMenuItem";
            this.alterarLoginSenhaMeuUsuarioMenuItem.Size = new System.Drawing.Size(219, 24);
            this.alterarLoginSenhaMeuUsuarioMenuItem.Text = "Alterar login && senha";
            this.alterarLoginSenhaMeuUsuarioMenuItem.Click += new System.EventHandler(this.alterarLoginSenhaMeuUsuarioMenuItem_Click);
            // 
            // sairMenuItem
            // 
            this.sairMenuItem.Name = "sairMenuItem";
            this.sairMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairMenuItem.Text = "&Sair";
            this.sairMenuItem.Click += new System.EventHandler(this.sairMenuItem_Click);
            // 
            // barraDeFerramentas
            // 
            this.barraDeFerramentas.ImageScalingSize = new System.Drawing.Size(47, 47);
            this.barraDeFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_InserirClienteBarraDeFerramentas,
            this.button_AniversariantesBarraDeFerramentas,
            this.button_InserirFuncionarioBarraDeFerramentas,
            this.button_InserirServicoBarraDeFerramentas,
            this.button_InserirUsuarioBarraDeFerramentas,
            this.toolStripButton1,
            this.button_AbriCaixa,
            this.button_SairBarraDeFerramentas});
            this.barraDeFerramentas.Location = new System.Drawing.Point(0, 28);
            this.barraDeFerramentas.Name = "barraDeFerramentas";
            this.barraDeFerramentas.Size = new System.Drawing.Size(749, 54);
            this.barraDeFerramentas.TabIndex = 1;
            // 
            // button_InserirClienteBarraDeFerramentas
            // 
            this.button_InserirClienteBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_InserirClienteBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_InserirClienteBarraDeFerramentas.Image")));
            this.button_InserirClienteBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_InserirClienteBarraDeFerramentas.Name = "button_InserirClienteBarraDeFerramentas";
            this.button_InserirClienteBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_InserirClienteBarraDeFerramentas.Text = "Inserir cliente";
            this.button_InserirClienteBarraDeFerramentas.Click += new System.EventHandler(this.button_CadastrarClienteBarraDeFerramentas_Click);
            // 
            // button_AniversariantesBarraDeFerramentas
            // 
            this.button_AniversariantesBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_AniversariantesBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_AniversariantesBarraDeFerramentas.Image")));
            this.button_AniversariantesBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_AniversariantesBarraDeFerramentas.Name = "button_AniversariantesBarraDeFerramentas";
            this.button_AniversariantesBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_AniversariantesBarraDeFerramentas.Text = "Aniversariantes";
            // 
            // button_InserirFuncionarioBarraDeFerramentas
            // 
            this.button_InserirFuncionarioBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_InserirFuncionarioBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_InserirFuncionarioBarraDeFerramentas.Image")));
            this.button_InserirFuncionarioBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_InserirFuncionarioBarraDeFerramentas.Name = "button_InserirFuncionarioBarraDeFerramentas";
            this.button_InserirFuncionarioBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_InserirFuncionarioBarraDeFerramentas.Text = "Inserir funcionário";
            this.button_InserirFuncionarioBarraDeFerramentas.Click += new System.EventHandler(this.button_InserirFuncionarioBarraDeFerramentas_Click);
            // 
            // button_InserirServicoBarraDeFerramentas
            // 
            this.button_InserirServicoBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_InserirServicoBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_InserirServicoBarraDeFerramentas.Image")));
            this.button_InserirServicoBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_InserirServicoBarraDeFerramentas.Name = "button_InserirServicoBarraDeFerramentas";
            this.button_InserirServicoBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_InserirServicoBarraDeFerramentas.Text = "Inserir serviço";
            this.button_InserirServicoBarraDeFerramentas.Click += new System.EventHandler(this.button_InserirServicoBarraDeFerramentas_Click);
            // 
            // button_InserirUsuarioBarraDeFerramentas
            // 
            this.button_InserirUsuarioBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_InserirUsuarioBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_InserirUsuarioBarraDeFerramentas.Image")));
            this.button_InserirUsuarioBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_InserirUsuarioBarraDeFerramentas.Name = "button_InserirUsuarioBarraDeFerramentas";
            this.button_InserirUsuarioBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_InserirUsuarioBarraDeFerramentas.Text = "Inserir usuário";
            this.button_InserirUsuarioBarraDeFerramentas.Click += new System.EventHandler(this.button_InserirUsuarioBarraDeFerramentas_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 51);
            this.toolStripButton1.Text = "Alterar usuário & senha";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button_AbriCaixa
            // 
            this.button_AbriCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_AbriCaixa.Image = ((System.Drawing.Image)(resources.GetObject("button_AbriCaixa.Image")));
            this.button_AbriCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_AbriCaixa.Name = "button_AbriCaixa";
            this.button_AbriCaixa.Size = new System.Drawing.Size(51, 51);
            this.button_AbriCaixa.Text = "Abrir caixa";
            this.button_AbriCaixa.Click += new System.EventHandler(this.button_AbriCaixa_Click);
            // 
            // button_SairBarraDeFerramentas
            // 
            this.button_SairBarraDeFerramentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_SairBarraDeFerramentas.Image = ((System.Drawing.Image)(resources.GetObject("button_SairBarraDeFerramentas.Image")));
            this.button_SairBarraDeFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_SairBarraDeFerramentas.Name = "button_SairBarraDeFerramentas";
            this.button_SairBarraDeFerramentas.Size = new System.Drawing.Size(51, 51);
            this.button_SairBarraDeFerramentas.Text = "Sair";
            this.button_SairBarraDeFerramentas.Click += new System.EventHandler(this.button_SairBarraDeFerramentas_Click);
            // 
            // Form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 382);
            this.Controls.Add(this.barraDeFerramentas);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Index";
            this.Text = "ArBelSys - Index";
            this.Load += new System.EventHandler(this.Form_Index_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.barraDeFerramentas.ResumeLayout(false);
            this.barraDeFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem clientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServicoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarServicosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaEstoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaEstoqueMenuItem;
        private System.Windows.Forms.ToolStrip barraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_InserirClienteBarraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_InserirServicoBarraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_InserirFuncionarioBarraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_SairBarraDeFerramentas;
        private System.Windows.Forms.ToolStripMenuItem sairMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCadastroMeuUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLoginSenhaMeuUsuarioMenuItem;
        private System.Windows.Forms.ToolStripButton button_InserirUsuarioBarraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_AniversariantesBarraDeFerramentas;
        private System.Windows.Forms.ToolStripButton button_AbriCaixa;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}