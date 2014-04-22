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
            this.tbBuscarCpfCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbCpfCliente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAIXA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCpfCliente);
            this.groupBox1.Controls.Add(this.tbNomeCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btBuscarCliente);
            this.groupBox1.Controls.Add(this.tbBuscarCpfCliente);
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
            this.tbBuscarCpfCliente.Location = new System.Drawing.Point(116, 13);
            this.tbBuscarCpfCliente.Name = "tbBuscarCpfCliente";
            this.tbBuscarCpfCliente.Size = new System.Drawing.Size(93, 20);
            this.tbBuscarCpfCliente.TabIndex = 1;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(24, 19);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(281, 21);
            this.cbFuncionario.TabIndex = 0;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(215, 11);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCliente.TabIndex = 2;
            this.btBuscarCliente.Text = "Buscar";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(65, 36);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(225, 20);
            this.tbNomeCliente.TabIndex = 4;
            // 
            // tbCpfCliente
            // 
            this.tbCpfCliente.Location = new System.Drawing.Point(65, 61);
            this.tbCpfCliente.Name = "tbCpfCliente";
            this.tbCpfCliente.ReadOnly = true;
            this.tbCpfCliente.Size = new System.Drawing.Size(133, 20);
            this.tbCpfCliente.TabIndex = 5;
            // 
            // TelaAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelaAbrirCaixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.TelaAbrirCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBuscarCpfCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.TextBox tbCpfCliente;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBuscarCliente;
    }
}