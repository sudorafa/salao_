namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    partial class FormularioRemoverServico
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
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.campoRemoverCodigoServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o CODIGO DE SERVIÇO que deseja Remover:";
            // 
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(197, 168);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 23);
            this.botaoRemover.TabIndex = 1;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(15, 168);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 2;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // campoRemoverCodigoServico
            // 
            this.campoRemoverCodigoServico.Location = new System.Drawing.Point(15, 93);
            this.campoRemoverCodigoServico.Name = "campoRemoverCodigoServico";
            this.campoRemoverCodigoServico.Size = new System.Drawing.Size(257, 20);
            this.campoRemoverCodigoServico.TabIndex = 3;
            // 
            // FormularioRemoverServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.campoRemoverCodigoServico);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.label1);
            this.Name = "FormularioRemoverServico";
            this.Text = "RemoverServico";
            this.Load += new System.EventHandler(this.FormularioRemoverServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoRemover;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.TextBox campoRemoverCodigoServico;
    }
}