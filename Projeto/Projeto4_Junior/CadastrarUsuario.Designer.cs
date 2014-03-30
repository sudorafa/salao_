namespace Projeto4_Junior
{
    partial class CadastrarUsuario
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
            this.DadosUsuario = new System.Windows.Forms.GroupBox();
            this.isGestor = new System.Windows.Forms.CheckBox();
            this.Senha_Usuario = new System.Windows.Forms.TextBox();
            this.Login_Usuario = new System.Windows.Forms.TextBox();
            this.Nome_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Salvar_Usuario = new System.Windows.Forms.Button();
            this.DadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DadosUsuario
            // 
            this.DadosUsuario.Controls.Add(this.isGestor);
            this.DadosUsuario.Controls.Add(this.Senha_Usuario);
            this.DadosUsuario.Controls.Add(this.Login_Usuario);
            this.DadosUsuario.Controls.Add(this.Nome_Usuario);
            this.DadosUsuario.Controls.Add(this.label3);
            this.DadosUsuario.Controls.Add(this.label2);
            this.DadosUsuario.Controls.Add(this.label1);
            this.DadosUsuario.Location = new System.Drawing.Point(23, 12);
            this.DadosUsuario.Name = "DadosUsuario";
            this.DadosUsuario.Size = new System.Drawing.Size(324, 169);
            this.DadosUsuario.TabIndex = 0;
            this.DadosUsuario.TabStop = false;
            this.DadosUsuario.Text = "Usuario";
            // 
            // isGestor
            // 
            this.isGestor.AutoSize = true;
            this.isGestor.Location = new System.Drawing.Point(50, 136);
            this.isGestor.Name = "isGestor";
            this.isGestor.Size = new System.Drawing.Size(57, 17);
            this.isGestor.TabIndex = 6;
            this.isGestor.Text = "Gestor";
            this.isGestor.UseVisualStyleBackColor = true;
            // 
            // Senha_Usuario
            // 
            this.Senha_Usuario.Location = new System.Drawing.Point(50, 94);
            this.Senha_Usuario.Name = "Senha_Usuario";
            this.Senha_Usuario.PasswordChar = '*';
            this.Senha_Usuario.Size = new System.Drawing.Size(134, 20);
            this.Senha_Usuario.TabIndex = 5;
            // 
            // Login_Usuario
            // 
            this.Login_Usuario.Location = new System.Drawing.Point(50, 64);
            this.Login_Usuario.Name = "Login_Usuario";
            this.Login_Usuario.Size = new System.Drawing.Size(134, 20);
            this.Login_Usuario.TabIndex = 4;
            // 
            // Nome_Usuario
            // 
            this.Nome_Usuario.Location = new System.Drawing.Point(50, 33);
            this.Nome_Usuario.Name = "Nome_Usuario";
            this.Nome_Usuario.Size = new System.Drawing.Size(237, 20);
            this.Nome_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(101, 187);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(81, 28);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Salvar_Usuario
            // 
            this.Salvar_Usuario.Location = new System.Drawing.Point(203, 187);
            this.Salvar_Usuario.Name = "Salvar_Usuario";
            this.Salvar_Usuario.Size = new System.Drawing.Size(81, 28);
            this.Salvar_Usuario.TabIndex = 2;
            this.Salvar_Usuario.Text = "Cadastrar";
            this.Salvar_Usuario.UseVisualStyleBackColor = true;
            this.Salvar_Usuario.Click += new System.EventHandler(this.Salvar_Usuario_Click);
            // 
            // CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.Salvar_Usuario);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.DadosUsuario);
            this.Name = "CadastrarUsuario";
            this.Text = "CadastrarUsuario";
            this.DadosUsuario.ResumeLayout(false);
            this.DadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DadosUsuario;
        private System.Windows.Forms.CheckBox isGestor;
        private System.Windows.Forms.TextBox Senha_Usuario;
        private System.Windows.Forms.TextBox Login_Usuario;
        private System.Windows.Forms.TextBox Nome_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Salvar_Usuario;
    }
}