namespace Projeto4_Junior
{
    partial class Form_CadastroClientes
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
            this.textBox_EmailCliente = new System.Windows.Forms.TextBox();
            this.label_EmailCliente = new System.Windows.Forms.Label();
            this.button_SalvarCadastroCliente = new System.Windows.Forms.Button();
            this.button_CancelarCadastroCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_EnderecoNumeroCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBox_EnderecoCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_EnderecoUfCliente = new System.Windows.Forms.ComboBox();
            this.textBox_EnderecoCidadeCliente = new System.Windows.Forms.TextBox();
            this.textBox_EnderecoBairroCliente = new System.Windows.Forms.TextBox();
            this.textBox_EnderecoComplementoCliente = new System.Windows.Forms.TextBox();
            this.textBox_EnderecoRuaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_CpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBox_TelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBox_DataNascCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_EmailCliente
            // 
            this.textBox_EmailCliente.Location = new System.Drawing.Point(73, 80);
            this.textBox_EmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EmailCliente.Name = "textBox_EmailCliente";
            this.textBox_EmailCliente.Size = new System.Drawing.Size(188, 20);
            this.textBox_EmailCliente.TabIndex = 5;
            // 
            // label_EmailCliente
            // 
            this.label_EmailCliente.AutoSize = true;
            this.label_EmailCliente.Location = new System.Drawing.Point(32, 83);
            this.label_EmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EmailCliente.Name = "label_EmailCliente";
            this.label_EmailCliente.Size = new System.Drawing.Size(35, 13);
            this.label_EmailCliente.TabIndex = 3;
            this.label_EmailCliente.Text = "Email:";
            // 
            // button_SalvarCadastroCliente
            // 
            this.button_SalvarCadastroCliente.Location = new System.Drawing.Point(583, 254);
            this.button_SalvarCadastroCliente.Name = "button_SalvarCadastroCliente";
            this.button_SalvarCadastroCliente.Size = new System.Drawing.Size(75, 23);
            this.button_SalvarCadastroCliente.TabIndex = 13;
            this.button_SalvarCadastroCliente.Text = "Cadastrar";
            this.button_SalvarCadastroCliente.UseVisualStyleBackColor = true;
            this.button_SalvarCadastroCliente.Click += new System.EventHandler(this.button_SalvarCadastroCliente_Click);
            // 
            // button_CancelarCadastroCliente
            // 
            this.button_CancelarCadastroCliente.Location = new System.Drawing.Point(463, 254);
            this.button_CancelarCadastroCliente.Name = "button_CancelarCadastroCliente";
            this.button_CancelarCadastroCliente.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarCadastroCliente.TabIndex = 14;
            this.button_CancelarCadastroCliente.Text = "Cancelar";
            this.button_CancelarCadastroCliente.UseVisualStyleBackColor = true;
            this.button_CancelarCadastroCliente.Click += new System.EventHandler(this.button_CancelarCadastroCliente_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_EnderecoNumeroCliente);
            this.groupBox1.Controls.Add(this.textBox_EnderecoCepCliente);
            this.groupBox1.Controls.Add(this.comboBox_EnderecoUfCliente);
            this.groupBox1.Controls.Add(this.textBox_EnderecoCidadeCliente);
            this.groupBox1.Controls.Add(this.textBox_EnderecoBairroCliente);
            this.groupBox1.Controls.Add(this.textBox_EnderecoComplementoCliente);
            this.groupBox1.Controls.Add(this.textBox_EnderecoRuaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(646, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // textBox_EnderecoNumeroCliente
            // 
            this.textBox_EnderecoNumeroCliente.Location = new System.Drawing.Point(344, 14);
            this.textBox_EnderecoNumeroCliente.Mask = "9999999999";
            this.textBox_EnderecoNumeroCliente.Name = "textBox_EnderecoNumeroCliente";
            this.textBox_EnderecoNumeroCliente.Size = new System.Drawing.Size(69, 20);
            this.textBox_EnderecoNumeroCliente.TabIndex = 7;
            // 
            // textBox_EnderecoCepCliente
            // 
            this.textBox_EnderecoCepCliente.Location = new System.Drawing.Point(78, 66);
            this.textBox_EnderecoCepCliente.Mask = "99999-999";
            this.textBox_EnderecoCepCliente.Name = "textBox_EnderecoCepCliente";
            this.textBox_EnderecoCepCliente.Size = new System.Drawing.Size(61, 20);
            this.textBox_EnderecoCepCliente.TabIndex = 10;
            // 
            // comboBox_EnderecoUfCliente
            // 
            this.comboBox_EnderecoUfCliente.FormattingEnabled = true;
            this.comboBox_EnderecoUfCliente.Items.AddRange(new object[] {
            "AC\t",
            "AL\t",
            "AP\t",
            "AM\t",
            "BA\t",
            "CE\t",
            "DF\t",
            "ES\t",
            "GO\t",
            "MA\t",
            "MT\t",
            "MS\t",
            "MG\t",
            "PA\t",
            "PB\t",
            "PR\t",
            "PE\t",
            "PI\t",
            "RJ\t",
            "RN\t",
            "RS\t",
            "RO\t",
            "RR\t",
            "SC\t",
            "SP\t",
            "SE\t",
            "TO"});
            this.comboBox_EnderecoUfCliente.Location = new System.Drawing.Point(525, 70);
            this.comboBox_EnderecoUfCliente.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EnderecoUfCliente.Name = "comboBox_EnderecoUfCliente";
            this.comboBox_EnderecoUfCliente.Size = new System.Drawing.Size(44, 21);
            this.comboBox_EnderecoUfCliente.TabIndex = 12;
            // 
            // textBox_EnderecoCidadeCliente
            // 
            this.textBox_EnderecoCidadeCliente.Location = new System.Drawing.Point(344, 69);
            this.textBox_EnderecoCidadeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EnderecoCidadeCliente.Name = "textBox_EnderecoCidadeCliente";
            this.textBox_EnderecoCidadeCliente.Size = new System.Drawing.Size(109, 20);
            this.textBox_EnderecoCidadeCliente.TabIndex = 11;
            // 
            // textBox_EnderecoBairroCliente
            // 
            this.textBox_EnderecoBairroCliente.Location = new System.Drawing.Point(344, 41);
            this.textBox_EnderecoBairroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EnderecoBairroCliente.Name = "textBox_EnderecoBairroCliente";
            this.textBox_EnderecoBairroCliente.Size = new System.Drawing.Size(109, 20);
            this.textBox_EnderecoBairroCliente.TabIndex = 9;
            // 
            // textBox_EnderecoComplementoCliente
            // 
            this.textBox_EnderecoComplementoCliente.Location = new System.Drawing.Point(78, 41);
            this.textBox_EnderecoComplementoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EnderecoComplementoCliente.Name = "textBox_EnderecoComplementoCliente";
            this.textBox_EnderecoComplementoCliente.Size = new System.Drawing.Size(190, 20);
            this.textBox_EnderecoComplementoCliente.TabIndex = 8;
            // 
            // textBox_EnderecoRuaCliente
            // 
            this.textBox_EnderecoRuaCliente.Location = new System.Drawing.Point(78, 17);
            this.textBox_EnderecoRuaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EnderecoRuaCliente.Name = "textBox_EnderecoRuaCliente";
            this.textBox_EnderecoRuaCliente.Size = new System.Drawing.Size(190, 20);
            this.textBox_EnderecoRuaCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rua:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_CpfCliente);
            this.groupBox2.Controls.Add(this.textBox_TelefoneCliente);
            this.groupBox2.Controls.Add(this.textBox_DataNascCliente);
            this.groupBox2.Controls.Add(this.textBox_EmailCliente);
            this.groupBox2.Controls.Add(this.label_EmailCliente);
            this.groupBox2.Controls.Add(this.textBox_NomeCliente);
            this.groupBox2.Controls.Add(this.lbDataNascimento);
            this.groupBox2.Controls.Add(this.lbCpf);
            this.groupBox2.Controls.Add(this.lbTelefone);
            this.groupBox2.Controls.Add(this.lbNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 110);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // textBox_CpfCliente
            // 
            this.textBox_CpfCliente.Location = new System.Drawing.Point(344, 19);
            this.textBox_CpfCliente.Mask = "999.999.999-99";
            this.textBox_CpfCliente.Name = "textBox_CpfCliente";
            this.textBox_CpfCliente.Size = new System.Drawing.Size(86, 20);
            this.textBox_CpfCliente.TabIndex = 2;
            // 
            // textBox_TelefoneCliente
            // 
            this.textBox_TelefoneCliente.Location = new System.Drawing.Point(73, 52);
            this.textBox_TelefoneCliente.Mask = "(99) 9999-9999";
            this.textBox_TelefoneCliente.Name = "textBox_TelefoneCliente";
            this.textBox_TelefoneCliente.Size = new System.Drawing.Size(83, 20);
            this.textBox_TelefoneCliente.TabIndex = 3;
            // 
            // textBox_DataNascCliente
            // 
            this.textBox_DataNascCliente.Location = new System.Drawing.Point(344, 49);
            this.textBox_DataNascCliente.Mask = "99/99/9999";
            this.textBox_DataNascCliente.Name = "textBox_DataNascCliente";
            this.textBox_DataNascCliente.Size = new System.Drawing.Size(67, 20);
            this.textBox_DataNascCliente.TabIndex = 4;
            // 
            // textBox_NomeCliente
            // 
            this.textBox_NomeCliente.Location = new System.Drawing.Point(73, 23);
            this.textBox_NomeCliente.Name = "textBox_NomeCliente";
            this.textBox_NomeCliente.Size = new System.Drawing.Size(195, 20);
            this.textBox_NomeCliente.TabIndex = 1;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(231, 55);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbDataNascimento.TabIndex = 3;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(308, 26);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(15, 55);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 1;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(29, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // Form_CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 287);
            this.Controls.Add(this.button_SalvarCadastroCliente);
            this.Controls.Add(this.button_CancelarCadastroCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form_CadastroClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EmailCliente;
        private System.Windows.Forms.Label label_EmailCliente;
        private System.Windows.Forms.Button button_SalvarCadastroCliente;
        private System.Windows.Forms.Button button_CancelarCadastroCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_EnderecoUfCliente;
        private System.Windows.Forms.TextBox textBox_EnderecoCidadeCliente;
        private System.Windows.Forms.TextBox textBox_EnderecoBairroCliente;
        private System.Windows.Forms.TextBox textBox_EnderecoComplementoCliente;
        private System.Windows.Forms.TextBox textBox_EnderecoRuaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_NomeCliente;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox textBox_EnderecoNumeroCliente;
        private System.Windows.Forms.MaskedTextBox textBox_EnderecoCepCliente;
        private System.Windows.Forms.MaskedTextBox textBox_CpfCliente;
        private System.Windows.Forms.MaskedTextBox textBox_TelefoneCliente;
        private System.Windows.Forms.MaskedTextBox textBox_DataNascCliente;
    }
}