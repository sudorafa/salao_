namespace Projeto4_Junior.InterfaceGrafica.Servicos
{
    partial class Form_Cadastro_Servico
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butao_voltar_tela_principal = new System.Windows.Forms.Button();
            this.butao_salvar = new System.Windows.Forms.Button();
            this.butao_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butao_voltar_tela_principal);
            this.groupBox2.Controls.Add(this.butao_salvar);
            this.groupBox2.Controls.Add(this.butao_cancelar);
            this.groupBox2.Location = new System.Drawing.Point(6, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 132);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Painel de Controle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // butao_voltar_tela_principal
            // 
            this.butao_voltar_tela_principal.Location = new System.Drawing.Point(54, 73);
            this.butao_voltar_tela_principal.Name = "butao_voltar_tela_principal";
            this.butao_voltar_tela_principal.Size = new System.Drawing.Size(125, 23);
            this.butao_voltar_tela_principal.TabIndex = 5;
            this.butao_voltar_tela_principal.Text = "Voltar Tela Principal";
            this.butao_voltar_tela_principal.UseVisualStyleBackColor = true;
            // 
            // butao_salvar
            // 
            this.butao_salvar.Location = new System.Drawing.Point(155, 36);
            this.butao_salvar.Name = "butao_salvar";
            this.butao_salvar.Size = new System.Drawing.Size(75, 23);
            this.butao_salvar.TabIndex = 4;
            this.butao_salvar.Text = "Salvar";
            this.butao_salvar.UseVisualStyleBackColor = true;
            this.butao_salvar.Click += new System.EventHandler(this.butao_salvar_Click);
            // 
            // butao_cancelar
            // 
            this.butao_cancelar.Location = new System.Drawing.Point(20, 36);
            this.butao_cancelar.Name = "butao_cancelar";
            this.butao_cancelar.Size = new System.Drawing.Size(75, 23);
            this.butao_cancelar.TabIndex = 3;
            this.butao_cancelar.Text = "Cancelar";
            this.butao_cancelar.UseVisualStyleBackColor = true;
            this.butao_cancelar.Click += new System.EventHandler(this.butao_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Serviços";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "corte masculino",
            "corte feminino",
            "penteados"});
            this.comboBox1.Location = new System.Drawing.Point(84, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form_Cadastro_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Cadastro_Servico";
            this.Text = "Serviço";
            this.Load += new System.EventHandler(this.Servico_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butao_voltar_tela_principal;
        private System.Windows.Forms.Button butao_salvar;
        private System.Windows.Forms.Button butao_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;


    }
}