namespace Projeto4_Junior
{
    partial class ListarCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeClienteBusca = new System.Windows.Forms.TextBox();
            this.AlterarCliente = new System.Windows.Forms.Button();
            this.RemoverCliente = new System.Windows.Forms.Button();
            this.BuscarListaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeto4DataSet = new Projeto4_Junior.Projeto4DataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto4_Junior.Projeto4DataSetTableAdapters.ClienteTableAdapter();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // nomeClienteBusca
            // 
            this.nomeClienteBusca.Location = new System.Drawing.Point(124, 35);
            this.nomeClienteBusca.Name = "nomeClienteBusca";
            this.nomeClienteBusca.Size = new System.Drawing.Size(354, 20);
            this.nomeClienteBusca.TabIndex = 1;
            // 
            // AlterarCliente
            // 
            this.AlterarCliente.Location = new System.Drawing.Point(257, 365);
            this.AlterarCliente.Name = "AlterarCliente";
            this.AlterarCliente.Size = new System.Drawing.Size(75, 48);
            this.AlterarCliente.TabIndex = 3;
            this.AlterarCliente.Text = "Alterar";
            this.AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // RemoverCliente
            // 
            this.RemoverCliente.Location = new System.Drawing.Point(390, 365);
            this.RemoverCliente.Name = "RemoverCliente";
            this.RemoverCliente.Size = new System.Drawing.Size(75, 48);
            this.RemoverCliente.TabIndex = 4;
            this.RemoverCliente.Text = "Remover";
            this.RemoverCliente.UseVisualStyleBackColor = true;
            // 
            // BuscarListaCliente
            // 
            this.BuscarListaCliente.Location = new System.Drawing.Point(484, 33);
            this.BuscarListaCliente.Name = "BuscarListaCliente";
            this.BuscarListaCliente.Size = new System.Drawing.Size(75, 23);
            this.BuscarListaCliente.TabIndex = 5;
            this.BuscarListaCliente.Text = "Buscar";
            this.BuscarListaCliente.UseVisualStyleBackColor = true;
            this.BuscarListaCliente.Click += new System.EventHandler(this.BuscarListaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.nomeClienteBusca);
            this.groupBox1.Controls.Add(this.AlterarCliente);
            this.groupBox1.Controls.Add(this.RemoverCliente);
            this.groupBox1.Controls.Add(this.BuscarListaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 419);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cpf});
            this.dataGridView1.Location = new System.Drawing.Point(43, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 252);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projeto4DataSet
            // 
            this.projeto4DataSet.DataSetName = "Projeto4DataSet";
            this.projeto4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.projeto4DataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 250;
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeClienteBusca;
        private System.Windows.Forms.Button AlterarCliente;
        private System.Windows.Forms.Button RemoverCliente;
        private System.Windows.Forms.Button BuscarListaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Projeto4DataSet projeto4DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Projeto4DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
    }
}