namespace Projeto4_Junior
{
    partial class ListarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeClienteBusca = new System.Windows.Forms.TextBox();
            this.ListaClientes = new System.Windows.Forms.ListView();
            this.AlterarCliente = new System.Windows.Forms.Button();
            this.RemoverCliente = new System.Windows.Forms.Button();
            this.BuscarListaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nomeClienteBusca
            // 
            this.nomeClienteBusca.Location = new System.Drawing.Point(124, 35);
            this.nomeClienteBusca.Name = "nomeClienteBusca";
            this.nomeClienteBusca.Size = new System.Drawing.Size(354, 20);
            this.nomeClienteBusca.TabIndex = 1;
            // 
            // ListaClientes
            // 
            this.ListaClientes.GridLines = true;
            this.ListaClientes.Location = new System.Drawing.Point(6, 71);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(709, 275);
            this.ListaClientes.TabIndex = 2;
            this.ListaClientes.UseCompatibleStateImageBehavior = false;
            // 
            // AlterarCliente
            // 
            this.AlterarCliente.Location = new System.Drawing.Point(257, 365);
            this.AlterarCliente.Name = "AlterarCliente";
            this.AlterarCliente.Size = new System.Drawing.Size(75, 48);
            this.AlterarCliente.TabIndex = 3;
            this.AlterarCliente.Text = "Alterar";
            this.AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // RemoverCliente
            // 
            this.RemoverCliente.Location = new System.Drawing.Point(390, 365);
            this.RemoverCliente.Name = "RemoverCliente";
            this.RemoverCliente.Size = new System.Drawing.Size(75, 48);
            this.RemoverCliente.TabIndex = 4;
            this.RemoverCliente.Text = "Remover";
            this.RemoverCliente.UseVisualStyleBackColor = true;
            // 
            // BuscarListaCliente
            // 
            this.BuscarListaCliente.Location = new System.Drawing.Point(484, 33);
            this.BuscarListaCliente.Name = "BuscarListaCliente";
            this.BuscarListaCliente.Size = new System.Drawing.Size(75, 23);
            this.BuscarListaCliente.TabIndex = 5;
            this.BuscarListaCliente.Text = "Buscar";
            this.BuscarListaCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeClienteBusca);
            this.groupBox1.Controls.Add(this.AlterarCliente);
            this.groupBox1.Controls.Add(this.RemoverCliente);
            this.groupBox1.Controls.Add(this.BuscarListaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListaClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 419);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeClienteBusca;
        private System.Windows.Forms.ListView ListaClientes;
        private System.Windows.Forms.Button AlterarCliente;
        private System.Windows.Forms.Button RemoverCliente;
        private System.Windows.Forms.Button BuscarListaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}