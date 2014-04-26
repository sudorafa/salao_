namespace Projeto4_Junior.InterfaceGrafica.Usuario
{
    partial class AlterarLoginSenha
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
            this.btAlterar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.DadosUsuario = new System.Windows.Forms.GroupBox();
            this.Senha_Usuario = new System.Windows.Forms.TextBox();
            this.Login_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(123, 209);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(81, 28);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(21, 209);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(81, 28);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // DadosUsuario
            // 
            this.DadosUsuario.Controls.Add(this.Senha_Usuario);
            this.DadosUsuario.Controls.Add(this.Login_Usuario);
            this.DadosUsuario.Controls.Add(this.label3);
            this.DadosUsuario.Controls.Add(this.label2);
            this.DadosUsuario.Location = new System.Drawing.Point(12, 34);
            this.DadosUsuario.Name = "DadosUsuario";
            this.DadosUsuario.Size = new System.Drawing.Size(199, 169);
            this.DadosUsuario.TabIndex = 5;
            this.DadosUsuario.TabStop = false;
            this.DadosUsuario.Text = "Usuario";
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
            // AlterarLoginSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 266);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.DadosUsuario);
            this.Name = "AlterarLoginSenha";
            this.Text = "AlterarLoginSenha";
            this.DadosUsuario.ResumeLayout(false);
            this.DadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox DadosUsuario;
        private System.Windows.Forms.TextBox Senha_Usuario;
        private System.Windows.Forms.TextBox Login_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}