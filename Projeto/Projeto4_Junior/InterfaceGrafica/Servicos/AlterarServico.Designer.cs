namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    partial class AlterarServico
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
            this.DadosUsuario = new System.Windows.Forms.GroupBox();
            this.Valor_Servico = new System.Windows.Forms.TextBox();
            this.Descricao_Servico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.DadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DadosUsuario
            // 
            this.DadosUsuario.Controls.Add(this.Valor_Servico);
            this.DadosUsuario.Controls.Add(this.Descricao_Servico);
            this.DadosUsuario.Controls.Add(this.label2);
            this.DadosUsuario.Controls.Add(this.label1);
            this.DadosUsuario.Location = new System.Drawing.Point(12, 12);
            this.DadosUsuario.Name = "DadosUsuario";
            this.DadosUsuario.Size = new System.Drawing.Size(324, 169);
            this.DadosUsuario.TabIndex = 2;
            this.DadosUsuario.TabStop = false;
            this.DadosUsuario.Text = "Usuario";
            // 
            // Valor_Servico
            // 
            this.Valor_Servico.Location = new System.Drawing.Point(70, 64);
            this.Valor_Servico.Name = "Valor_Servico";
            this.Valor_Servico.Size = new System.Drawing.Size(134, 20);
            this.Valor_Servico.TabIndex = 4;
            // 
            // Descricao_Servico
            // 
            this.Descricao_Servico.Location = new System.Drawing.Point(70, 33);
            this.Descricao_Servico.Name = "Descricao_Servico";
            this.Descricao_Servico.Size = new System.Drawing.Size(217, 20);
            this.Descricao_Servico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(192, 197);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(81, 28);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(90, 197);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(81, 28);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // AlterarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.DadosUsuario);
            this.Controls.Add(this.Cancelar);
            this.Name = "AlterarServico";
            this.Text = "AlterarServico";
            this.Load += new System.EventHandler(this.AlterarServico_Load);
            this.DadosUsuario.ResumeLayout(false);
            this.DadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DadosUsuario;
        private System.Windows.Forms.TextBox Valor_Servico;
        private System.Windows.Forms.TextBox Descricao_Servico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button Cancelar;
    }
}