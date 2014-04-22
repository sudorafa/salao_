namespace Projeto4_Junior.InterfaceGrafica.Produtos
{
    partial class CadastroProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.ValorProduto = new System.Windows.Forms.TextBox();
            this.QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuantidadeProduto);
            this.groupBox1.Controls.Add(this.ValorProduto);
            this.groupBox1.Controls.Add(this.DescricaoProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
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
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(90, 37);
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(318, 20);
            this.DescricaoProduto.TabIndex = 3;
            // 
            // ValorProduto
            // 
            this.ValorProduto.Location = new System.Drawing.Point(90, 76);
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.Size = new System.Drawing.Size(88, 20);
            this.ValorProduto.TabIndex = 4;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.Location = new System.Drawing.Point(97, 118);
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.Size = new System.Drawing.Size(45, 20);
            this.QuantidadeProduto.TabIndex = 5;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(245, 192);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(356, 192);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 7;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 238);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelar);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QuantidadeProduto;
        private System.Windows.Forms.TextBox ValorProduto;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Cadastrar;
    }
}