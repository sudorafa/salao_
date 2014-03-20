namespace Projeto4_Junior
{
    partial class Form_AlterarCliente
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
            this.label_AlterarCliente = new System.Windows.Forms.Label();
            this.textBox_AlterarCliente = new System.Windows.Forms.TextBox();
            this.button_CancelarAlteraracaoCliente = new System.Windows.Forms.Button();
            this.button_AlterarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AlterarCliente
            // 
            this.label_AlterarCliente.AutoSize = true;
            this.label_AlterarCliente.Location = new System.Drawing.Point(43, 23);
            this.label_AlterarCliente.Name = "label_AlterarCliente";
            this.label_AlterarCliente.Size = new System.Drawing.Size(274, 17);
            this.label_AlterarCliente.TabIndex = 1;
            this.label_AlterarCliente.Text = "Digite o CPF do cliente que deseja alterar:";
            // 
            // textBox_AlterarCliente
            // 
            this.textBox_AlterarCliente.Location = new System.Drawing.Point(131, 46);
            this.textBox_AlterarCliente.Name = "textBox_AlterarCliente";
            this.textBox_AlterarCliente.Size = new System.Drawing.Size(100, 22);
            this.textBox_AlterarCliente.TabIndex = 1;
            // 
            // button_CancelarAlteraracaoCliente
            // 
            this.button_CancelarAlteraracaoCliente.Location = new System.Drawing.Point(103, 76);
            this.button_CancelarAlteraracaoCliente.Name = "button_CancelarAlteraracaoCliente";
            this.button_CancelarAlteraracaoCliente.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarAlteraracaoCliente.TabIndex = 2;
            this.button_CancelarAlteraracaoCliente.Text = "Cancelar";
            this.button_CancelarAlteraracaoCliente.UseVisualStyleBackColor = true;
            this.button_CancelarAlteraracaoCliente.Click += new System.EventHandler(this.button_CancelarAlteraracaoCliente_Click);
            // 
            // button_AlterarCliente
            // 
            this.button_AlterarCliente.Location = new System.Drawing.Point(184, 76);
            this.button_AlterarCliente.Name = "button_AlterarCliente";
            this.button_AlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarCliente.TabIndex = 3;
            this.button_AlterarCliente.Text = "Alterar";
            this.button_AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // Form_AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 111);
            this.Controls.Add(this.button_AlterarCliente);
            this.Controls.Add(this.button_CancelarAlteraracaoCliente);
            this.Controls.Add(this.textBox_AlterarCliente);
            this.Controls.Add(this.label_AlterarCliente);
            this.MaximizeBox = false;
            this.Name = "Form_AlterarCliente";
            this.Text = "Alterar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AlterarCliente;
        private System.Windows.Forms.TextBox textBox_AlterarCliente;
        private System.Windows.Forms.Button button_CancelarAlteraracaoCliente;
        private System.Windows.Forms.Button button_AlterarCliente;
    }
}