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
            this.nomeClienteBusca = new System.Windows.Forms.TextBox();
            this.btAlterarFuncionario = new System.Windows.Forms.Button();
            this.btRemoverFuncionario = new System.Windows.Forms.Button();
            this.btBuscaFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaFuncionario = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeClienteBusca);
            this.groupBox1.Controls.Add(this.btAlterarFuncionario);
            this.groupBox1.Controls.Add(this.btRemoverFuncionario);
            this.groupBox1.Controls.Add(this.btBuscaFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListaFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 419);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários";
            // 
            // nomeClienteBusca
            // 
            this.nomeClienteBusca.Location = new System.Drawing.Point(124, 35);
            this.nomeClienteBusca.Name = "nomeClienteBusca";
            this.nomeClienteBusca.Size = new System.Drawing.Size(354, 20);
            this.nomeClienteBusca.TabIndex = 1;
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
            // btBuscaFuncionario
            // 
            this.btBuscaFuncionario.Location = new System.Drawing.Point(484, 33);
            this.btBuscaFuncionario.Name = "btBuscaFuncionario";
            this.btBuscaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btBuscaFuncionario.TabIndex = 5;
            this.btBuscaFuncionario.Text = "Buscar";
            this.btBuscaFuncionario.UseVisualStyleBackColor = true;
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
            // ListaFuncionario
            // 
            this.ListaFuncionario.GridLines = true;
            this.ListaFuncionario.Location = new System.Drawing.Point(6, 71);
            this.ListaFuncionario.Name = "ListaFuncionario";
            this.ListaFuncionario.Size = new System.Drawing.Size(709, 275);
            this.ListaFuncionario.TabIndex = 2;
            this.ListaFuncionario.UseCompatibleStateImageBehavior = false;
            // 
            // ListarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarFuncionario";
            this.Text = "ListarFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nomeClienteBusca;
        private System.Windows.Forms.Button btAlterarFuncionario;
        private System.Windows.Forms.Button btRemoverFuncionario;
        private System.Windows.Forms.Button btBuscaFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaFuncionario;
    }
}