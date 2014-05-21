namespace Projeto4_Junior.InterfaceGrafica.Caixa
{
    partial class TelaAbrirCaixa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBuscarCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.tbCpfCliente = new System.Windows.Forms.TextBox();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAdicionarServico = new System.Windows.Forms.Button();
            this.cbServicos = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.dGListaServProd = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btFinalizarVenda = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGListaServProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAIXA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBuscarCpfCliente);
            this.groupBox1.Controls.Add(this.tbCpfCliente);
            this.groupBox1.Controls.Add(this.tbNomeCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btBuscarCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // tbBuscarCpfCliente
            // 
            this.tbBuscarCpfCliente.Location = new System.Drawing.Point(112, 13);
            this.tbBuscarCpfCliente.Mask = "999.999.999-99";
            this.tbBuscarCpfCliente.Name = "tbBuscarCpfCliente";
            this.tbBuscarCpfCliente.Size = new System.Drawing.Size(86, 20);
            this.tbBuscarCpfCliente.TabIndex = 10;
            // 
            // tbCpfCliente
            // 
            this.tbCpfCliente.Location = new System.Drawing.Point(65, 61);
            this.tbCpfCliente.Name = "tbCpfCliente";
            this.tbCpfCliente.ReadOnly = true;
            this.tbCpfCliente.Size = new System.Drawing.Size(133, 20);
            this.tbCpfCliente.TabIndex = 5;
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(65, 36);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(225, 20);
            this.tbNomeCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(215, 11);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCliente.TabIndex = 2;
            this.btBuscarCliente.Text = "Buscar";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar pelo CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(344, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(23, 35);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(281, 21);
            this.cbFuncionario.TabIndex = 3;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAdicionarServico);
            this.groupBox3.Controls.Add(this.cbServicos);
            this.groupBox3.Location = new System.Drawing.Point(12, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // btAdicionarServico
            // 
            this.btAdicionarServico.Location = new System.Drawing.Point(248, 33);
            this.btAdicionarServico.Name = "btAdicionarServico";
            this.btAdicionarServico.Size = new System.Drawing.Size(60, 23);
            this.btAdicionarServico.TabIndex = 5;
            this.btAdicionarServico.Text = "Adicionar";
            this.btAdicionarServico.UseVisualStyleBackColor = true;
            this.btAdicionarServico.Click += new System.EventHandler(this.btAdicionarServico_Click);
            // 
            // cbServicos
            // 
            this.cbServicos.FormattingEnabled = true;
            this.cbServicos.Location = new System.Drawing.Point(24, 33);
            this.cbServicos.Name = "cbServicos";
            this.cbServicos.Size = new System.Drawing.Size(218, 21);
            this.cbServicos.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btAdicionarProduto);
            this.groupBox4.Controls.Add(this.cbProdutos);
            this.groupBox4.Location = new System.Drawing.Point(344, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(247, 33);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(60, 23);
            this.btAdicionarProduto.TabIndex = 7;
            this.btAdicionarProduto.Text = "Adicionar";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(23, 33);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(215, 21);
            this.cbProdutos.TabIndex = 6;
            // 
            // dGListaServProd
            // 
            this.dGListaServProd.AllowUserToAddRows = false;
            this.dGListaServProd.AllowUserToDeleteRows = false;
            this.dGListaServProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGListaServProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.valor,
            this.remover,
            this.idProduto,
            this.idServico});
            this.dGListaServProd.Location = new System.Drawing.Point(12, 284);
            this.dGListaServProd.Name = "dGListaServProd";
            this.dGListaServProd.ReadOnly = true;
            this.dGListaServProd.Size = new System.Drawing.Size(657, 180);
            this.dGListaServProd.TabIndex = 5;
            this.dGListaServProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGListaServProd_CellContentClick);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(29, 506);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(153, 33);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Total - R$";
            // 
            // btFinalizarVenda
            // 
            this.btFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarVenda.Location = new System.Drawing.Point(517, 508);
            this.btFinalizarVenda.Name = "btFinalizarVenda";
            this.btFinalizarVenda.Size = new System.Drawing.Size(131, 45);
            this.btFinalizarVenda.TabIndex = 8;
            this.btFinalizarVenda.Text = "Finalizar Venda";
            this.btFinalizarVenda.UseVisualStyleBackColor = true;
            this.btFinalizarVenda.Click += new System.EventHandler(this.btFinalizarVenda_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(430, 508);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 45);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lbValorTotal.Location = new System.Drawing.Point(179, 506);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(82, 31);
            this.lbValorTotal.TabIndex = 9;
            this.lbValorTotal.Text = "00,00";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 400;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 112;
            // 
            // remover
            // 
            this.remover.HeaderText = "";
            this.remover.Name = "remover";
            this.remover.ReadOnly = true;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
            // 
            // idServico
            // 
            this.idServico.HeaderText = "idServico";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            this.idServico.Visible = false;
            // 
            // TelaAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 565);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFinalizarVenda);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dGListaServProd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelaAbrirCaixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.TelaAbrirCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGListaServProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.TextBox tbCpfCliente;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbServicos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.DataGridView dGListaServProd;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btFinalizarVenda;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdicionarServico;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.MaskedTextBox tbBuscarCpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewButtonColumn remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
    }
}