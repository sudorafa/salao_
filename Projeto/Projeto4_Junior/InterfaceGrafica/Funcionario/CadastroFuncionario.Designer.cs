namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    partial class CadastroFuncionario
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
            this.gbCadFunc = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataDeNascimento = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbDataDeNascimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCadFunc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadFunc
            // 
            this.gbCadFunc.Controls.Add(this.tbDataDeNascimento);
            this.gbCadFunc.Controls.Add(this.tbTelefone);
            this.gbCadFunc.Controls.Add(this.tbCpf);
            this.gbCadFunc.Controls.Add(this.tbNome);
            this.gbCadFunc.Controls.Add(this.lbDataDeNascimento);
            this.gbCadFunc.Controls.Add(this.lbTelefone);
            this.gbCadFunc.Controls.Add(this.lbCpf);
            this.gbCadFunc.Controls.Add(this.lbName);
            this.gbCadFunc.Location = new System.Drawing.Point(12, 12);
            this.gbCadFunc.Name = "gbCadFunc";
            this.gbCadFunc.Size = new System.Drawing.Size(269, 133);
            this.gbCadFunc.TabIndex = 0;
            this.gbCadFunc.TabStop = false;
            this.gbCadFunc.Text = "Dados Pessoais";
            this.gbCadFunc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(16, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nome:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCep);
            this.groupBox1.Controls.Add(this.tbBairro);
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(24, 53);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(34, 13);
            this.lbCpf.TabIndex = 1;
            this.lbCpf.Text = "CPF:*";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(2, 79);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(56, 13);
            this.lbTelefone.TabIndex = 2;
            this.lbTelefone.Text = "Telefone:*";
            // 
            // lbDataDeNascimento
            // 
            this.lbDataDeNascimento.AutoSize = true;
            this.lbDataDeNascimento.Location = new System.Drawing.Point(6, 108);
            this.lbDataDeNascimento.Name = "lbDataDeNascimento";
            this.lbDataDeNascimento.Size = new System.Drawing.Size(111, 13);
            this.lbDataDeNascimento.TabIndex = 3;
            this.lbDataDeNascimento.Text = "Data de Nascimento:*";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(60, 24);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(203, 20);
            this.tbNome.TabIndex = 4;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(61, 50);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(82, 20);
            this.tbCpf.TabIndex = 5;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(60, 76);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(83, 20);
            this.tbTelefone.TabIndex = 6;
            // 
            // tbDataDeNascimento
            // 
            this.tbDataDeNascimento.Location = new System.Drawing.Point(119, 105);
            this.tbDataDeNascimento.Name = "tbDataDeNascimento";
            this.tbDataDeNascimento.Size = new System.Drawing.Size(80, 20);
            this.tbDataDeNascimento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rua/Av:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N°:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP:*";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "PE",
            "PB",
            "DF",
            "AC",
            "SP",
            "RJ",
            "MG",
            "ES",
            "GO",
            "MT",
            "MS",
            "AM",
            "AL",
            "MA",
            "RS"});
            this.cbEstado.Location = new System.Drawing.Point(59, 101);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(35, 21);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(60, 22);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(203, 20);
            this.tbRua.TabIndex = 6;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(60, 48);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(121, 20);
            this.tbCidade.TabIndex = 7;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(215, 48);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(47, 20);
            this.tbNumero.TabIndex = 8;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(59, 75);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(84, 20);
            this.tbBairro.TabIndex = 9;
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(190, 75);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(74, 20);
            this.tbCep.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado:*";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(202, 288);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(118, 288);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "* Campo Obrigatório.";
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 333);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCadFunc);
            this.MaximizeBox = false;
            this.Name = "CadastroFuncionario";
            this.Text = "Cadastro Funcionario";
            this.gbCadFunc.ResumeLayout(false);
            this.gbCadFunc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadFunc;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbDataDeNascimento;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbDataDeNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label7;
    }
}