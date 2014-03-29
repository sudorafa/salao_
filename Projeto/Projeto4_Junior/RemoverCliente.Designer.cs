namespace Projeto4_Junior
{
    partial class Form_RemoverCliente
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
            this.button_RemoverCliente = new System.Windows.Forms.Button();
            this.button_CancelarRemocaoCliente = new System.Windows.Forms.Button();
            this.textBox_RemoverCliente = new System.Windows.Forms.TextBox();
            this.label_RemoverCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_RemoverCliente
            // 
            this.button_RemoverCliente.Location = new System.Drawing.Point(145, 58);
            this.button_RemoverCliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoverCliente.Name = "button_RemoverCliente";
            this.button_RemoverCliente.Size = new System.Drawing.Size(61, 19);
            this.button_RemoverCliente.TabIndex = 3;
            this.button_RemoverCliente.Text = "Remover";
            this.button_RemoverCliente.UseVisualStyleBackColor = true;
            this.button_RemoverCliente.Click += new System.EventHandler(this.button_RemoverCliente_Click);
            // 
            // button_CancelarRemocaoCliente
            // 
            this.button_CancelarRemocaoCliente.Location = new System.Drawing.Point(76, 58);
            this.button_CancelarRemocaoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_CancelarRemocaoCliente.Name = "button_CancelarRemocaoCliente";
            this.button_CancelarRemocaoCliente.Size = new System.Drawing.Size(65, 19);
            this.button_CancelarRemocaoCliente.TabIndex = 2;
            this.button_CancelarRemocaoCliente.Text = "Cancelar";
            this.button_CancelarRemocaoCliente.UseVisualStyleBackColor = true;
            this.button_CancelarRemocaoCliente.Click += new System.EventHandler(this.button_CancelarRemocaoCliente_Click);
            // 
            // textBox_RemoverCliente
            // 
            this.textBox_RemoverCliente.Location = new System.Drawing.Point(96, 34);
            this.textBox_RemoverCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_RemoverCliente.Name = "textBox_RemoverCliente";
            this.textBox_RemoverCliente.Size = new System.Drawing.Size(76, 20);
            this.textBox_RemoverCliente.TabIndex = 1;
            // 
            // label_RemoverCliente
            // 
            this.label_RemoverCliente.AutoSize = true;
            this.label_RemoverCliente.Location = new System.Drawing.Point(30, 15);
            this.label_RemoverCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RemoverCliente.Name = "label_RemoverCliente";
            this.label_RemoverCliente.Size = new System.Drawing.Size(219, 13);
            this.label_RemoverCliente.TabIndex = 5;
            this.label_RemoverCliente.Text = "Digite o CPF do cliente que deseja Remover:";
            // 
            // Form_RemoverCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 90);
            this.Controls.Add(this.button_RemoverCliente);
            this.Controls.Add(this.button_CancelarRemocaoCliente);
            this.Controls.Add(this.textBox_RemoverCliente);
            this.Controls.Add(this.label_RemoverCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_RemoverCliente";
            this.Text = "Remover Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RemoverCliente;
        private System.Windows.Forms.Button button_CancelarRemocaoCliente;
        private System.Windows.Forms.TextBox textBox_RemoverCliente;
        private System.Windows.Forms.Label label_RemoverCliente;
    }
}