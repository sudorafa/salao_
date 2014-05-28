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
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btFinalizarVenda = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(348, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 69);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(433, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // tbBuscarCpfCliente
            // 
            this.tbBuscarCpfCliente.Location = new System.Drawing.Point(149, 16);
            this.tbBuscarCpfCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBuscarCpfCliente.Mask = "999.999.999-99";
            this.tbBuscarCpfCliente.Name = "tbBuscarCpfCliente";
            this.tbBuscarCpfCliente.Size = new System.Drawing.Size(113, 22);
            this.tbBuscarCpfCliente.TabIndex = 10;
            // 
            // tbCpfCliente
            // 
            this.tbCpfCliente.Location = new System.Drawing.Point(87, 75);
            this.tbCpfCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCpfCliente.Name = "tbCpfCliente";
            this.tbCpfCliente.ReadOnly = true;
            this.tbCpfCliente.Size = new System.Drawing.Size(176, 22);
            this.tbCpfCliente.TabIndex = 5;
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(87, 44);
            this.tbNomeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(299, 22);
            this.tbNomeCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(287, 14);
            this.btBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(100, 28);
            this.btBuscarCliente.TabIndex = 2;
            this.btBuscarCliente.Text = "Buscar";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar pelo CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(459, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(433, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(31, 43);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(373, 24);
            this.cbFuncionario.TabIndex = 3;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAdicionarServico);
            this.groupBox3.Controls.Add(this.cbServicos);
            this.groupBox3.Location = new System.Drawing.Point(16, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(433, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // btAdicionarServico
            // 
            this.btAdicionarServico.Location = new System.Drawing.Point(331, 41);
            this.btAdicionarServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdicionarServico.Name = "btAdicionarServico";
            this.btAdicionarServico.Size = new System.Drawing.Size(80, 28);
            this.btAdicionarServico.TabIndex = 5;
            this.btAdicionarServico.Text = "Adicionar";
            this.btAdicionarServico.UseVisualStyleBackColor = true;
            this.btAdicionarServico.Click += new System.EventHandler(this.btAdicionarServico_Click);
            // 
            // cbServicos
            // 
            this.cbServicos.FormattingEnabled = true;
            this.cbServicos.Location = new System.Drawing.Point(32, 41);
            this.cbServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbServicos.Name = "cbServicos";
            this.cbServicos.Size = new System.Drawing.Size(289, 24);
            this.cbServicos.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btAdicionarProduto);
            this.groupBox4.Controls.Add(this.cbProdutos);
            this.groupBox4.Location = new System.Drawing.Point(459, 240);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(433, 91);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(329, 41);
            this.btAdicionarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(80, 28);
            this.btAdicionarProduto.TabIndex = 7;
            this.btAdicionarProduto.Text = "Adicionar";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(31, 41);
            this.cbProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(285, 24);
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
            this.dGListaServProd.Location = new System.Drawing.Point(16, 350);
            this.dGListaServProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGListaServProd.Name = "dGListaServProd";
            this.dGListaServProd.ReadOnly = true;
            this.dGListaServProd.Size = new System.Drawing.Size(876, 222);
            this.dGListaServProd.TabIndex = 5;
            this.dGListaServProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGListaServProd_CellContentClick);
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
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(39, 623);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(191, 42);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "Total - R$";
            // 
            // btFinalizarVenda
            // 
            this.btFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarVenda.Location = new System.Drawing.Point(689, 625);
            this.btFinalizarVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFinalizarVenda.Name = "btFinalizarVenda";
            this.btFinalizarVenda.Size = new System.Drawing.Size(175, 55);
            this.btFinalizarVenda.TabIndex = 8;
            this.btFinalizarVenda.Text = "Finalizar Venda";
            this.btFinalizarVenda.UseVisualStyleBackColor = true;
            this.btFinalizarVenda.Click += new System.EventHandler(this.btFinalizarVenda_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(573, 625);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 55);
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
            this.lbValorTotal.Location = new System.Drawing.Point(239, 623);
            this.lbValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(102, 39);
            this.lbValorTotal.TabIndex = 9;
            this.lbValorTotal.Text = "00,00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 625);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gerar Balanço Diário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 695);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}