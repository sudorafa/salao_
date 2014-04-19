namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    partial class AlterarServicoPrincipal
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
            this.campoCodigoServico_FormeTelaPrincipal = new System.Windows.Forms.TextBox();
            this.campoDescricaoServico_FormeTelaPrincipal = new System.Windows.Forms.TextBox();
            this.campoValorServico_FormeTelaPrincipal = new System.Windows.Forms.TextBox();
            this.botaoAlterarTelaServicoPrincipal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoCodigoServico_FormeTelaPrincipal
            // 
            this.campoCodigoServico_FormeTelaPrincipal.Location = new System.Drawing.Point(108, 32);
            this.campoCodigoServico_FormeTelaPrincipal.Name = "campoCodigoServico_FormeTelaPrincipal";
            this.campoCodigoServico_FormeTelaPrincipal.Size = new System.Drawing.Size(164, 20);
            this.campoCodigoServico_FormeTelaPrincipal.TabIndex = 0;
            // 
            // campoDescricaoServico_FormeTelaPrincipal
            // 
            this.campoDescricaoServico_FormeTelaPrincipal.Location = new System.Drawing.Point(108, 87);
            this.campoDescricaoServico_FormeTelaPrincipal.Name = "campoDescricaoServico_FormeTelaPrincipal";
            this.campoDescricaoServico_FormeTelaPrincipal.Size = new System.Drawing.Size(164, 20);
            this.campoDescricaoServico_FormeTelaPrincipal.TabIndex = 1;
            // 
            // campoValorServico_FormeTelaPrincipal
            // 
            this.campoValorServico_FormeTelaPrincipal.Location = new System.Drawing.Point(108, 140);
            this.campoValorServico_FormeTelaPrincipal.Name = "campoValorServico_FormeTelaPrincipal";
            this.campoValorServico_FormeTelaPrincipal.Size = new System.Drawing.Size(100, 20);
            this.campoValorServico_FormeTelaPrincipal.TabIndex = 2;
            // 
            // botaoAlterarTelaServicoPrincipal
            // 
            this.botaoAlterarTelaServicoPrincipal.Location = new System.Drawing.Point(173, 208);
            this.botaoAlterarTelaServicoPrincipal.Name = "botaoAlterarTelaServicoPrincipal";
            this.botaoAlterarTelaServicoPrincipal.Size = new System.Drawing.Size(75, 23);
            this.botaoAlterarTelaServicoPrincipal.TabIndex = 3;
            this.botaoAlterarTelaServicoPrincipal.Text = "Alterar";
            this.botaoAlterarTelaServicoPrincipal.UseVisualStyleBackColor = true;
            this.botaoAlterarTelaServicoPrincipal.Click += new System.EventHandler(this.botaoAlterarTelaServicoPrincipal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Serviço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // AlterarServicoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoAlterarTelaServicoPrincipal);
            this.Controls.Add(this.campoValorServico_FormeTelaPrincipal);
            this.Controls.Add(this.campoDescricaoServico_FormeTelaPrincipal);
            this.Controls.Add(this.campoCodigoServico_FormeTelaPrincipal);
            this.Name = "AlterarServicoPrincipal";
            this.Text = "AlterarServicoPrincipal";
            this.Load += new System.EventHandler(this.AlterarServicoPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoCodigoServico_FormeTelaPrincipal;
        private System.Windows.Forms.TextBox campoDescricaoServico_FormeTelaPrincipal;
        private System.Windows.Forms.TextBox campoValorServico_FormeTelaPrincipal;
        private System.Windows.Forms.Button botaoAlterarTelaServicoPrincipal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}