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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoDescricaoTelaAlterar = new System.Windows.Forms.TextBox();
            this.botaoAlterarTelaAlterar = new System.Windows.Forms.Button();
            this.botaoCancelarTelaAlterar = new System.Windows.Forms.Button();
            this.campoValorTelaAlterar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // campoDescricaoTelaAlterar
            // 
            this.campoDescricaoTelaAlterar.Location = new System.Drawing.Point(76, 43);
            this.campoDescricaoTelaAlterar.Name = "campoDescricaoTelaAlterar";
            this.campoDescricaoTelaAlterar.Size = new System.Drawing.Size(196, 20);
            this.campoDescricaoTelaAlterar.TabIndex = 1;
            // 
            // botaoAlterarTelaAlterar
            // 
            this.botaoAlterarTelaAlterar.Location = new System.Drawing.Point(197, 197);
            this.botaoAlterarTelaAlterar.Name = "botaoAlterarTelaAlterar";
            this.botaoAlterarTelaAlterar.Size = new System.Drawing.Size(75, 23);
            this.botaoAlterarTelaAlterar.TabIndex = 3;
            this.botaoAlterarTelaAlterar.Text = "Alterar";
            this.botaoAlterarTelaAlterar.UseVisualStyleBackColor = true;
            this.botaoAlterarTelaAlterar.Click += new System.EventHandler(this.botaoAlterarTelaAlterar_Click);
            // 
            // botaoCancelarTelaAlterar
            // 
            this.botaoCancelarTelaAlterar.Location = new System.Drawing.Point(15, 197);
            this.botaoCancelarTelaAlterar.Name = "botaoCancelarTelaAlterar";
            this.botaoCancelarTelaAlterar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelarTelaAlterar.TabIndex = 4;
            this.botaoCancelarTelaAlterar.Text = "Cancelar";
            this.botaoCancelarTelaAlterar.UseVisualStyleBackColor = true;
            this.botaoCancelarTelaAlterar.Click += new System.EventHandler(this.botaoCancelarTelaAlterar_Click);
            // 
            // campoValorTelaAlterar
            // 
            this.campoValorTelaAlterar.Location = new System.Drawing.Point(76, 84);
            this.campoValorTelaAlterar.Mask = "9999999999999999999999999999999999999";
            this.campoValorTelaAlterar.Name = "campoValorTelaAlterar";
            this.campoValorTelaAlterar.Size = new System.Drawing.Size(196, 20);
            this.campoValorTelaAlterar.TabIndex = 2;
            // 
            // AlterarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.campoValorTelaAlterar);
            this.Controls.Add(this.botaoCancelarTelaAlterar);
            this.Controls.Add(this.botaoAlterarTelaAlterar);
            this.Controls.Add(this.campoDescricaoTelaAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlterarServico";
            this.Text = "AlterarServico";
            this.Load += new System.EventHandler(this.AlterarServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoDescricaoTelaAlterar;
        private System.Windows.Forms.Button botaoAlterarTelaAlterar;
        private System.Windows.Forms.Button botaoCancelarTelaAlterar;
        private System.Windows.Forms.MaskedTextBox campoValorTelaAlterar;
    }
}