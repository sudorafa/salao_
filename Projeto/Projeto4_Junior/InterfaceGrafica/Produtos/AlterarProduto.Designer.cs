namespace Projeto4_Junior.InterfaceGrafica.Produtos
{
    partial class AlterarProduto
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
            this.DescricaoPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alterar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.QuantidadeProd = new System.Windows.Forms.MaskedTextBox();
            this.ValorProd = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuantidadeProd);
            this.groupBox1.Controls.Add(this.ValorProd);
            this.groupBox1.Controls.Add(this.DescricaoPro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // DescricaoPro
            // 
            this.DescricaoPro.Location = new System.Drawing.Point(90, 37);
            this.DescricaoPro.Name = "DescricaoPro";
            this.DescricaoPro.Size = new System.Drawing.Size(318, 20);
            this.DescricaoPro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(333, 203);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(222, 203);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // QuantidadeProd
            // 
            this.QuantidadeProd.Location = new System.Drawing.Point(97, 118);
            this.QuantidadeProd.Mask = "9999999999";
            this.QuantidadeProd.Name = "QuantidadeProd";
            this.QuantidadeProd.Size = new System.Drawing.Size(69, 20);
            this.QuantidadeProd.TabIndex = 3;
            // 
            // ValorProd
            // 
            this.ValorProd.Location = new System.Drawing.Point(90, 76);
            this.ValorProd.Mask = "9999999999999999999999999999999999999";
            this.ValorProd.Name = "ValorProd";
            this.ValorProd.Size = new System.Drawing.Size(229, 20);
            this.ValorProd.TabIndex = 2;
            // 
            // AlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 238);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlterarProduto";
            this.Text = "AlterarProduto";
            this.Load += new System.EventHandler(this.AlterarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DescricaoPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.MaskedTextBox QuantidadeProd;
        private System.Windows.Forms.MaskedTextBox ValorProd;
    }
}