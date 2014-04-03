namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    partial class ListarFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btAlterarFuncionario = new System.Windows.Forms.Button();
            this.btRemoverFuncionario = new System.Windows.Forms.Button();
            this.btBuscarFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNomeFuncionario);
            this.groupBox1.Controls.Add(this.btAlterarFuncionario);
            this.groupBox1.Controls.Add(this.btRemoverFuncionario);
            this.groupBox1.Controls.Add(this.btBuscarFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListaClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 419);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários";
            // 
            // tbNomeFuncionario
            // 
            this.tbNomeFuncionario.Location = new System.Drawing.Point(124, 35);
            this.tbNomeFuncionario.Name = "tbNomeFuncionario";
            this.tbNomeFuncionario.Size = new System.Drawing.Size(354, 20);
            this.tbNomeFuncionario.TabIndex = 1;
            // 
            // btAlterarFuncionario
            // 
            this.btAlterarFuncionario.Location = new System.Drawing.Point(257, 365);
            this.btAlterarFuncionario.Name = "btAlterarFuncionario";
            this.btAlterarFuncionario.Size = new System.Drawing.Size(75, 48);
            this.btAlterarFuncionario.TabIndex = 3;
            this.btAlterarFuncionario.Text = "Alterar";
            this.btAlterarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btRemoverFuncionario
            // 
            this.btRemoverFuncionario.Location = new System.Drawing.Point(390, 365);
            this.btRemoverFuncionario.Name = "btRemoverFuncionario";
            this.btRemoverFuncionario.Size = new System.Drawing.Size(75, 48);
            this.btRemoverFuncionario.TabIndex = 4;
            this.btRemoverFuncionario.Text = "Remover";
            this.btRemoverFuncionario.UseVisualStyleBackColor = true;
            // 
            // btBuscarFuncionario
            // 
            this.btBuscarFuncionario.Location = new System.Drawing.Point(484, 33);
            this.btBuscarFuncionario.Name = "btBuscarFuncionario";
            this.btBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btBuscarFuncionario.TabIndex = 5;
            this.btBuscarFuncionario.Text = "Buscar";
            this.btBuscarFuncionario.UseVisualStyleBackColor = true;
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
            // ListaClientes
            // 
            this.ListaClientes.GridLines = true;
            this.ListaClientes.Location = new System.Drawing.Point(6, 71);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(709, 275);
            this.ListaClientes.TabIndex = 2;
            this.ListaClientes.UseCompatibleStateImageBehavior = false;
            // 
            // ListarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarFuncionario";
            this.Text = "Listar Funcionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNomeFuncionario;
        private System.Windows.Forms.Button btAlterarFuncionario;
        private System.Windows.Forms.Button btRemoverFuncionario;
        private System.Windows.Forms.Button btBuscarFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaClientes;
    }
}