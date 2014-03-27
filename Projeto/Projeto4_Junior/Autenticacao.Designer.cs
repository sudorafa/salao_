namespace Projeto4_Junior
{
    partial class Autenticacao
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
            this.group_autenticacao = new System.Windows.Forms.GroupBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.group_autenticacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_autenticacao
            // 
            this.group_autenticacao.Controls.Add(this.pictureBox1);
            this.group_autenticacao.Controls.Add(this.senha);
            this.group_autenticacao.Controls.Add(this.usuario);
            this.group_autenticacao.Controls.Add(this.label2);
            this.group_autenticacao.Controls.Add(this.label1);
            this.group_autenticacao.Location = new System.Drawing.Point(21, 12);
            this.group_autenticacao.Name = "group_autenticacao";
            this.group_autenticacao.Size = new System.Drawing.Size(386, 162);
            this.group_autenticacao.TabIndex = 0;
            this.group_autenticacao.TabStop = false;
            this.group_autenticacao.Text = "Login";
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(102, 110);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(195, 20);
            this.senha.TabIndex = 3;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(102, 52);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(225, 20);
            this.usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(123, 180);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(81, 28);
            this.entrar.TabIndex = 1;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Aviso.Location = new System.Drawing.Point(9, 230);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(391, 13);
            this.Aviso.TabIndex = 2;
            this.Aviso.Text = "Caso você não tenha um usuário cadastrado no sistema, contate o administrador.\r\n";
            this.Aviso.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto4_Junior.Properties.Resources.cadeado;
            this.pictureBox1.Location = new System.Drawing.Point(6, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 103);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.group_autenticacao);
            this.Name = "Autenticacao";
            this.Text = "Autenticacao";
            this.Load += new System.EventHandler(this.Autenticacao_Load);
            this.group_autenticacao.ResumeLayout(false);
            this.group_autenticacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_autenticacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}