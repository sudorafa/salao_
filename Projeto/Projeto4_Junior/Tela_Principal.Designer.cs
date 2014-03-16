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
            this.buscarClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenuItem,
            this.funcionariosMenuItem,
            this.servicosMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(539, 24);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "MenuPrincipal";
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteMenuItem,
            this.alterarClienteMenuItem,
            this.buscarClienteMenuItem,
            this.removerClienteMenuItem,
            this.aniversariantesClienteMenuItem});
            this.clientesMenuItem.Name = "clientesMenuItem";
            this.clientesMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesMenuItem.Text = "&Clientes";
            // 
            // inserirClienteMenuItem
            // 
            this.inserirClienteMenuItem.Name = "inserirClienteMenuItem";
            this.inserirClienteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.inserirClienteMenuItem.Text = "Inserir";
            // 
            // alterarClienteMenuItem
            // 
            this.alterarClienteMenuItem.Name = "alterarClienteMenuItem";
            this.alterarClienteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alterarClienteMenuItem.Text = "Alterar";
            // 
            // buscarClienteMenuItem
            // 
            this.buscarClienteMenuItem.Name = "buscarClienteMenuItem";
            this.buscarClienteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.buscarClienteMenuItem.Text = "Buscar";
            // 
            // removerClienteMenuItem
            // 
            this.removerClienteMenuItem.Name = "removerClienteMenuItem";
            this.removerClienteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removerClienteMenuItem.Text = "Remover";
            // 
            // aniversariantesClienteMenuItem
            // 
            this.aniversariantesClienteMenuItem.Name = "aniversariantesClienteMenuItem";
            this.aniversariantesClienteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aniversariantesClienteMenuItem.Text = "Aniversariantes";
            // 
            // funcionariosMenuItem
            // 
            this.funcionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirFuncionarioMenuItem,
            this.alterarFuncionarioMenuItem,
            this.buscarFuncionarioMenuItem,
            this.removerFuncionarioMenuItem});
            this.funcionariosMenuItem.Name = "funcionariosMenuItem";
            this.funcionariosMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionariosMenuItem.Text = "&Funcionários";
            // 
            // inserirFuncionarioMenuItem
            // 
            this.inserirFuncionarioMenuItem.Name = "inserirFuncionarioMenuItem";
            this.inserirFuncionarioMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserirFuncionarioMenuItem.Text = "Inserir";
            // 
            // alterarFuncionarioMenuItem
            // 
            this.alterarFuncionarioMenuItem.Name = "alterarFuncionarioMenuItem";
            this.alterarFuncionarioMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarFuncionarioMenuItem.Text = "Alterar";
            // 
            // buscarFuncionarioMenuItem
            // 
            this.buscarFuncionarioMenuItem.Name = "buscarFuncionarioMenuItem";
            this.buscarFuncionarioMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarFuncionarioMenuItem.Text = "Buscar";
            // 
            // removerFuncionarioMenuItem
            // 
            this.removerFuncionarioMenuItem.Name = "removerFuncionarioMenuItem";
            this.removerFuncionarioMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removerFuncionarioMenuItem.Text = "Remover";
            // 
            // servicosMenuItem
            // 
            this.servicosMenuItem.Name = "servicosMenuItem";
            this.servicosMenuItem.Size = new System.Drawing.Size(62, 20);
            this.servicosMenuItem.Text = "&Serviços";
            // 
            // Form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 310);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
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
        private System.Windows.Forms.ToolStripMenuItem buscarClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerFuncionarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosMenuItem;
    }
}