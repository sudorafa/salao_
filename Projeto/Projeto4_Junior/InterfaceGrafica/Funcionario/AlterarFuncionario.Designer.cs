namespace Projeto4_Junior.InterfaceGrafica.Funcionario
{
    partial class AlterarFuncionario
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
            this.button_AlterarCliente = new System.Windows.Forms.Button();
            this.button_CancelarAlteraracaoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AlterarCliente
            // 
            this.label_AlterarCliente.AutoSize = true;
            this.label_AlterarCliente.Location = new System.Drawing.Point(25, 9);
            this.label_AlterarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AlterarCliente.Name = "label_AlterarCliente";
            this.label_AlterarCliente.Size = new System.Drawing.Size(226, 13);
            this.label_AlterarCliente.TabIndex = 2;
            this.label_AlterarCliente.Text = "Digite o CPF do funcionário que deseja alterar:";
            // 
            // textBox_AlterarCliente
            // 
            this.textBox_AlterarCliente.Location = new System.Drawing.Point(97, 24);
            this.textBox_AlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AlterarCliente.Name = "textBox_AlterarCliente";
            this.textBox_AlterarCliente.Size = new System.Drawing.Size(76, 20);
            this.textBox_AlterarCliente.TabIndex = 3;
            // 
            // button_AlterarCliente
            // 
            this.button_AlterarCliente.Location = new System.Drawing.Point(136, 48);
            this.button_AlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_AlterarCliente.Name = "button_AlterarCliente";
            this.button_AlterarCliente.Size = new System.Drawing.Size(56, 19);
            this.button_AlterarCliente.TabIndex = 5;
            this.button_AlterarCliente.Text = "Alterar";
            this.button_AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // button_CancelarAlteraracaoCliente
            // 
            this.button_CancelarAlteraracaoCliente.Location = new System.Drawing.Point(75, 48);
            this.button_CancelarAlteraracaoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_CancelarAlteraracaoCliente.Name = "button_CancelarAlteraracaoCliente";
            this.button_CancelarAlteraracaoCliente.Size = new System.Drawing.Size(56, 19);
            this.button_CancelarAlteraracaoCliente.TabIndex = 4;
            this.button_CancelarAlteraracaoCliente.Text = "Cancelar";
            this.button_CancelarAlteraracaoCliente.UseVisualStyleBackColor = true;
            // 
            // AlterarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 77);
            this.Controls.Add(this.button_AlterarCliente);
            this.Controls.Add(this.button_CancelarAlteraracaoCliente);
            this.Controls.Add(this.textBox_AlterarCliente);
            this.Controls.Add(this.label_AlterarCliente);
            this.MaximizeBox = false;
            this.Name = "AlterarFuncionario";
            this.Text = "Alteração do Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AlterarCliente;
        private System.Windows.Forms.TextBox textBox_AlterarCliente;
        private System.Windows.Forms.Button button_AlterarCliente;
        private System.Windows.Forms.Button button_CancelarAlteraracaoCliente;
    }
}