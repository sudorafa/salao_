﻿namespace Projeto4_Junior.InterfaceGrafica.Cliente
{
    partial class DetalharCliente
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
            this.groupBox_EnderecoCadastroCliente = new System.Windows.Forms.GroupBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDataNascimento = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label_EmailCliente = new System.Windows.Forms.Label();
            this.groupBox_EnderecoCadastroCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_EnderecoCadastroCliente
            // 
            this.groupBox_EnderecoCadastroCliente.Controls.Add(this.tbEndereco);
            this.groupBox_EnderecoCadastroCliente.Location = new System.Drawing.Point(12, 140);
            this.groupBox_EnderecoCadastroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_EnderecoCadastroCliente.Name = "groupBox_EnderecoCadastroCliente";
            this.groupBox_EnderecoCadastroCliente.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_EnderecoCadastroCliente.Size = new System.Drawing.Size(646, 87);
            this.groupBox_EnderecoCadastroCliente.TabIndex = 18;
            this.groupBox_EnderecoCadastroCliente.TabStop = false;
            this.groupBox_EnderecoCadastroCliente.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(18, 18);
            this.tbEndereco.Multiline = true;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.ReadOnly = true;
            this.tbEndereco.Size = new System.Drawing.Size(612, 54);
            this.tbEndereco.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label_EmailCliente);
            this.groupBox1.Controls.Add(this.tbDataNascimento);
            this.groupBox1.Controls.Add(this.tbCpf);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.lbDataNascimento);
            this.groupBox1.Controls.Add(this.lbCpf);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Location = new System.Drawing.Point(344, 52);
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.ReadOnly = true;
            this.tbDataNascimento.Size = new System.Drawing.Size(96, 20);
            this.tbDataNascimento.TabIndex = 7;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(344, 23);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.ReadOnly = true;
            this.tbCpf.Size = new System.Drawing.Size(96, 20);
            this.tbCpf.TabIndex = 6;
            this.tbCpf.TextChanged += new System.EventHandler(this.tbCpf_TextChanged);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(73, 52);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.ReadOnly = true;
            this.tbTelefone.Size = new System.Drawing.Size(99, 20);
            this.tbTelefone.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(73, 23);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(195, 20);
            this.tbNome.TabIndex = 4;
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
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(73, 80);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(188, 20);
            this.tbEmail.TabIndex = 8;
            // 
            // label_EmailCliente
            // 
            this.label_EmailCliente.AutoSize = true;
            this.label_EmailCliente.Location = new System.Drawing.Point(29, 83);
            this.label_EmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EmailCliente.Name = "label_EmailCliente";
            this.label_EmailCliente.Size = new System.Drawing.Size(35, 13);
            this.label_EmailCliente.TabIndex = 9;
            this.label_EmailCliente.Text = "Email:";
            // 
            // DetalharCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 248);
            this.Controls.Add(this.groupBox_EnderecoCadastroCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetalharCliente";
            this.Text = "DetalharCliente";
            this.groupBox_EnderecoCadastroCliente.ResumeLayout(false);
            this.groupBox_EnderecoCadastroCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_EnderecoCadastroCliente;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDataNascimento;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label_EmailCliente;
    }
}