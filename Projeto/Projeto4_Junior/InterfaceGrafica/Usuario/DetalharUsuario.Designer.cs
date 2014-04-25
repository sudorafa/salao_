namespace Projeto4_Junior.InterfaceGrafica.Usuario
{
    partial class DetalharUsuario
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
            this.Senha_Usu = new System.Windows.Forms.TextBox();
            this.Login_Usu = new System.Windows.Forms.TextBox();
            this.Nome_Usu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tipo_Usu = new System.Windows.Forms.TextBox();
            this.DadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DadosUsuario
            // 
            this.DadosUsuario.Controls.Add(this.Tipo_Usu);
            this.DadosUsuario.Controls.Add(this.label4);
            this.DadosUsuario.Controls.Add(this.Senha_Usu);
            this.DadosUsuario.Controls.Add(this.Login_Usu);
            this.DadosUsuario.Controls.Add(this.Nome_Usu);
            this.DadosUsuario.Controls.Add(this.label3);
            this.DadosUsuario.Controls.Add(this.label2);
            this.DadosUsuario.Controls.Add(this.label1);
            this.DadosUsuario.Location = new System.Drawing.Point(12, 12);
            this.DadosUsuario.Name = "DadosUsuario";
            this.DadosUsuario.Size = new System.Drawing.Size(324, 169);
            this.DadosUsuario.TabIndex = 1;
            this.DadosUsuario.TabStop = false;
            this.DadosUsuario.Text = "Usuario";
            // 
            // Senha_Usu
            // 
            this.Senha_Usu.Location = new System.Drawing.Point(50, 94);
            this.Senha_Usu.Name = "Senha_Usu";
            this.Senha_Usu.ReadOnly = true;
            this.Senha_Usu.Size = new System.Drawing.Size(134, 20);
            this.Senha_Usu.TabIndex = 5;
            // 
            // Login_Usu
            // 
            this.Login_Usu.Location = new System.Drawing.Point(50, 64);
            this.Login_Usu.Name = "Login_Usu";
            this.Login_Usu.ReadOnly = true;
            this.Login_Usu.Size = new System.Drawing.Size(134, 20);
            this.Login_Usu.TabIndex = 4;
            // 
            // Nome_Usu
            // 
            this.Nome_Usu.Location = new System.Drawing.Point(50, 33);
            this.Nome_Usu.Name = "Nome_Usu";
            this.Nome_Usu.ReadOnly = true;
            this.Nome_Usu.Size = new System.Drawing.Size(237, 20);
            this.Nome_Usu.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Usuario:";
            // 
            // Tipo_Usu
            // 
            this.Tipo_Usu.Location = new System.Drawing.Point(82, 127);
            this.Tipo_Usu.Name = "Tipo_Usu";
            this.Tipo_Usu.ReadOnly = true;
            this.Tipo_Usu.Size = new System.Drawing.Size(100, 20);
            this.Tipo_Usu.TabIndex = 7;
            // 
            // DetalharUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 201);
            this.Controls.Add(this.DadosUsuario);
            this.Name = "DetalharUsuario";
            this.Text = "DetalharUsuario";
            this.Load += new System.EventHandler(this.DetalharUsuario_Load);
            this.DadosUsuario.ResumeLayout(false);
            this.DadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DadosUsuario;
        private System.Windows.Forms.TextBox Tipo_Usu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Senha_Usu;
        private System.Windows.Forms.TextBox Login_Usu;
        private System.Windows.Forms.TextBox Nome_Usu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}