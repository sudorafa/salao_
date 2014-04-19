namespace Projeto4_Junior.InterfaceGrafica.Servico
{
    partial class FormularioCadastrarServico
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
            this.botao_cadastrar = new System.Windows.Forms.Button();
            this.botao_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campo_codigo_servico = new System.Windows.Forms.TextBox();
            this.campo_descricao = new System.Windows.Forms.TextBox();
            this.campo_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botao_cadastrar
            // 
            this.botao_cadastrar.Location = new System.Drawing.Point(172, 210);
            this.botao_cadastrar.Name = "botao_cadastrar";
            this.botao_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.botao_cadastrar.TabIndex = 0;
            this.botao_cadastrar.Text = "Cadastrar";
            this.botao_cadastrar.UseVisualStyleBackColor = true;
            this.botao_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botao_cancelar
            // 
            this.botao_cancelar.Location = new System.Drawing.Point(48, 210);
            this.botao_cancelar.Name = "botao_cancelar";
            this.botao_cancelar.Size = new System.Drawing.Size(75, 23);
            this.botao_cancelar.TabIndex = 1;
            this.botao_cancelar.Text = "Cancelar";
            this.botao_cancelar.UseVisualStyleBackColor = true;
            this.botao_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo do Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // campo_codigo_servico
            // 
            this.campo_codigo_servico.Location = new System.Drawing.Point(112, 37);
            this.campo_codigo_servico.Name = "campo_codigo_servico";
            this.campo_codigo_servico.Size = new System.Drawing.Size(160, 20);
            this.campo_codigo_servico.TabIndex = 5;
            // 
            // campo_descricao
            // 
            this.campo_descricao.Location = new System.Drawing.Point(112, 77);
            this.campo_descricao.Name = "campo_descricao";
            this.campo_descricao.Size = new System.Drawing.Size(160, 20);
            this.campo_descricao.TabIndex = 6;
            // 
            // campo_valor
            // 
            this.campo_valor.Location = new System.Drawing.Point(112, 119);
            this.campo_valor.Name = "campo_valor";
            this.campo_valor.Size = new System.Drawing.Size(100, 20);
            this.campo_valor.TabIndex = 7;
            // 
            // FormularioCadastrarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.campo_valor);
            this.Controls.Add(this.campo_descricao);
            this.Controls.Add(this.campo_codigo_servico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao_cancelar);
            this.Controls.Add(this.botao_cadastrar);
            this.Name = "FormularioCadastrarServico";
            this.Text = "CadastrarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_cadastrar;
        private System.Windows.Forms.Button botao_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campo_codigo_servico;
        private System.Windows.Forms.TextBox campo_descricao;
        private System.Windows.Forms.TextBox campo_valor;
    }
}