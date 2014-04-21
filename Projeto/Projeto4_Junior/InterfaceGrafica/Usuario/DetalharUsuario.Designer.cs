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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeUsu = new System.Windows.Forms.TextBox();
            this.SenhaUsu = new System.Windows.Forms.TextBox();
            this.LoginUsu = new System.Windows.Forms.TextBox();
            this.TipoUsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TipoUsu);
            this.groupBox1.Controls.Add(this.LoginUsu);
            this.groupBox1.Controls.Add(this.SenhaUsu);
            this.groupBox1.Controls.Add(this.NomeUsu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // NomeUsu
            // 
            this.NomeUsu.Location = new System.Drawing.Point(84, 33);
            this.NomeUsu.Name = "NomeUsu";
            this.NomeUsu.ReadOnly = true;
            this.NomeUsu.Size = new System.Drawing.Size(228, 20);
            this.NomeUsu.TabIndex = 3;
            // 
            // SenhaUsu
            // 
            this.SenhaUsu.Location = new System.Drawing.Point(84, 106);
            this.SenhaUsu.Name = "SenhaUsu";
            this.SenhaUsu.ReadOnly = true;
            this.SenhaUsu.Size = new System.Drawing.Size(104, 20);
            this.SenhaUsu.TabIndex = 4;
            // 
            // LoginUsu
            // 
            this.LoginUsu.Location = new System.Drawing.Point(84, 71);
            this.LoginUsu.Name = "LoginUsu";
            this.LoginUsu.ReadOnly = true;
            this.LoginUsu.Size = new System.Drawing.Size(104, 20);
            this.LoginUsu.TabIndex = 5;
            // 
            // TipoUsu
            // 
            this.TipoUsu.Location = new System.Drawing.Point(84, 149);
            this.TipoUsu.Name = "TipoUsu";
            this.TipoUsu.ReadOnly = true;
            this.TipoUsu.Size = new System.Drawing.Size(104, 20);
            this.TipoUsu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:";
            // 
            // DetalharUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 216);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetalharUsuario";
            this.Text = "DetalharUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TipoUsu;
        private System.Windows.Forms.TextBox LoginUsu;
        private System.Windows.Forms.TextBox SenhaUsu;
        private System.Windows.Forms.TextBox NomeUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}