namespace Projeto4_Junior.InterfaceGrafica.Produtos
{
    partial class ListarProdutos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProdutoBuscado = new System.Windows.Forms.TextBox();
            this.BuscarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ProdutoBuscado);
            this.groupBox1.Controls.Add(this.BuscarProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 354);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Valor,
            this.Quantidade,
            this.remover,
            this.alterar});
            this.dataGridView1.Location = new System.Drawing.Point(18, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 260);
            this.dataGridView1.TabIndex = 6;
            // 
            // ProdutoBuscado
            // 
            this.ProdutoBuscado.Location = new System.Drawing.Point(124, 35);
            this.ProdutoBuscado.Name = "ProdutoBuscado";
            this.ProdutoBuscado.Size = new System.Drawing.Size(354, 20);
            this.ProdutoBuscado.TabIndex = 1;
            // 
            // BuscarProduto
            // 
            this.BuscarProduto.Location = new System.Drawing.Point(484, 33);
            this.BuscarProduto.Name = "BuscarProduto";
            this.BuscarProduto.Size = new System.Drawing.Size(75, 23);
            this.BuscarProduto.TabIndex = 5;
            this.BuscarProduto.Text = "Buscar";
            this.BuscarProduto.UseVisualStyleBackColor = true;
            this.BuscarProduto.Click += new System.EventHandler(this.BuscarProduto_Click);
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
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 220;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 130;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // remover
            // 
            this.remover.HeaderText = "";
            this.remover.Name = "remover";
            this.remover.ReadOnly = true;
            this.remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remover.Text = "ee";
            // 
            // alterar
            // 
            this.alterar.HeaderText = "";
            this.alterar.Name = "alterar";
            this.alterar.ReadOnly = true;
            this.alterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarProdutos";
            this.Text = "ListarProdutos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ProdutoBuscado;
        private System.Windows.Forms.Button BuscarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewButtonColumn remover;
        private System.Windows.Forms.DataGridViewButtonColumn alterar;
    }
}