namespace Projeto4_Junior
{
    partial class Form_ListarClientes
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
            this.groupBox_FormaDeLista = new System.Windows.Forms.GroupBox();
            this.label_LetraParaBusca = new System.Windows.Forms.Label();
            this.textBox_LetraParaBusca = new System.Windows.Forms.TextBox();
            this.button_RealizarBusca = new System.Windows.Forms.Button();
            this.button_CancelarLista = new System.Windows.Forms.Button();
            this.radioButton_ListaCompleta = new System.Windows.Forms.RadioButton();
            this.radioButton_ListaPorLetra = new System.Windows.Forms.RadioButton();
            this.groupBox_ResultadoDaBusca = new System.Windows.Forms.GroupBox();
            this.button_NovaBusca = new System.Windows.Forms.Button();
            this.button_AlterarClienteBusca = new System.Windows.Forms.Button();
            this.dataGridView_ResultadoDaBusca = new System.Windows.Forms.DataGridView();
            this.groupBox_FormaDeLista.SuspendLayout();
            this.groupBox_ResultadoDaBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultadoDaBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_FormaDeLista
            // 
            this.groupBox_FormaDeLista.Controls.Add(this.label_LetraParaBusca);
            this.groupBox_FormaDeLista.Controls.Add(this.textBox_LetraParaBusca);
            this.groupBox_FormaDeLista.Controls.Add(this.button_RealizarBusca);
            this.groupBox_FormaDeLista.Controls.Add(this.button_CancelarLista);
            this.groupBox_FormaDeLista.Controls.Add(this.radioButton_ListaCompleta);
            this.groupBox_FormaDeLista.Controls.Add(this.radioButton_ListaPorLetra);
            this.groupBox_FormaDeLista.Location = new System.Drawing.Point(15, 8);
            this.groupBox_FormaDeLista.Name = "groupBox_FormaDeLista";
            this.groupBox_FormaDeLista.Size = new System.Drawing.Size(440, 121);
            this.groupBox_FormaDeLista.TabIndex = 0;
            this.groupBox_FormaDeLista.TabStop = false;
            this.groupBox_FormaDeLista.Text = "Escolha a forma de lista:";
            // 
            // label_LetraParaBusca
            // 
            this.label_LetraParaBusca.AutoSize = true;
            this.label_LetraParaBusca.Location = new System.Drawing.Point(94, 56);
            this.label_LetraParaBusca.Name = "label_LetraParaBusca";
            this.label_LetraParaBusca.Size = new System.Drawing.Size(307, 17);
            this.label_LetraParaBusca.TabIndex = 5;
            this.label_LetraParaBusca.Text = "* Digite aqui a letra que deseja realizar a busca";
            // 
            // textBox_LetraParaBusca
            // 
            this.textBox_LetraParaBusca.Location = new System.Drawing.Point(50, 51);
            this.textBox_LetraParaBusca.Name = "textBox_LetraParaBusca";
            this.textBox_LetraParaBusca.Size = new System.Drawing.Size(36, 22);
            this.textBox_LetraParaBusca.TabIndex = 3;
            // 
            // button_RealizarBusca
            // 
            this.button_RealizarBusca.Location = new System.Drawing.Point(225, 86);
            this.button_RealizarBusca.Name = "button_RealizarBusca";
            this.button_RealizarBusca.Size = new System.Drawing.Size(75, 23);
            this.button_RealizarBusca.TabIndex = 5;
            this.button_RealizarBusca.Text = "Listar";
            this.button_RealizarBusca.UseVisualStyleBackColor = true;
            // 
            // button_CancelarLista
            // 
            this.button_CancelarLista.Location = new System.Drawing.Point(144, 86);
            this.button_CancelarLista.Name = "button_CancelarLista";
            this.button_CancelarLista.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarLista.TabIndex = 4;
            this.button_CancelarLista.Text = "Cancelar";
            this.button_CancelarLista.UseVisualStyleBackColor = true;
            this.button_CancelarLista.Click += new System.EventHandler(this.button_CancelarLista_Click);
            // 
            // radioButton_ListaCompleta
            // 
            this.radioButton_ListaCompleta.AutoSize = true;
            this.radioButton_ListaCompleta.Location = new System.Drawing.Point(227, 21);
            this.radioButton_ListaCompleta.Name = "radioButton_ListaCompleta";
            this.radioButton_ListaCompleta.Size = new System.Drawing.Size(122, 21);
            this.radioButton_ListaCompleta.TabIndex = 2;
            this.radioButton_ListaCompleta.Text = "Lista Completa";
            this.radioButton_ListaCompleta.UseVisualStyleBackColor = true;
            // 
            // radioButton_ListaPorLetra
            // 
            this.radioButton_ListaPorLetra.AutoSize = true;
            this.radioButton_ListaPorLetra.Checked = true;
            this.radioButton_ListaPorLetra.Location = new System.Drawing.Point(97, 21);
            this.radioButton_ListaPorLetra.Name = "radioButton_ListaPorLetra";
            this.radioButton_ListaPorLetra.Size = new System.Drawing.Size(126, 21);
            this.radioButton_ListaPorLetra.TabIndex = 1;
            this.radioButton_ListaPorLetra.TabStop = true;
            this.radioButton_ListaPorLetra.Text = "Listar por Letra";
            this.radioButton_ListaPorLetra.UseVisualStyleBackColor = true;
            // 
            // groupBox_ResultadoDaBusca
            // 
            this.groupBox_ResultadoDaBusca.Controls.Add(this.button_NovaBusca);
            this.groupBox_ResultadoDaBusca.Controls.Add(this.button_AlterarClienteBusca);
            this.groupBox_ResultadoDaBusca.Controls.Add(this.dataGridView_ResultadoDaBusca);
            this.groupBox_ResultadoDaBusca.Location = new System.Drawing.Point(15, 128);
            this.groupBox_ResultadoDaBusca.Name = "groupBox_ResultadoDaBusca";
            this.groupBox_ResultadoDaBusca.Size = new System.Drawing.Size(439, 234);
            this.groupBox_ResultadoDaBusca.TabIndex = 1;
            this.groupBox_ResultadoDaBusca.TabStop = false;
            this.groupBox_ResultadoDaBusca.Text = "Resultado da busca:";
            // 
            // button_NovaBusca
            // 
            this.button_NovaBusca.Location = new System.Drawing.Point(219, 201);
            this.button_NovaBusca.Name = "button_NovaBusca";
            this.button_NovaBusca.Size = new System.Drawing.Size(93, 23);
            this.button_NovaBusca.TabIndex = 7;
            this.button_NovaBusca.Text = "Nova Busca";
            this.button_NovaBusca.UseVisualStyleBackColor = true;
            // 
            // button_AlterarClienteBusca
            // 
            this.button_AlterarClienteBusca.Location = new System.Drawing.Point(138, 201);
            this.button_AlterarClienteBusca.Name = "button_AlterarClienteBusca";
            this.button_AlterarClienteBusca.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarClienteBusca.TabIndex = 6;
            this.button_AlterarClienteBusca.Text = "Alterar";
            this.button_AlterarClienteBusca.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ResultadoDaBusca
            // 
            this.dataGridView_ResultadoDaBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ResultadoDaBusca.Location = new System.Drawing.Point(15, 23);
            this.dataGridView_ResultadoDaBusca.Name = "dataGridView_ResultadoDaBusca";
            this.dataGridView_ResultadoDaBusca.RowTemplate.Height = 24;
            this.dataGridView_ResultadoDaBusca.Size = new System.Drawing.Size(413, 171);
            this.dataGridView_ResultadoDaBusca.TabIndex = 0;
            // 
            // Form_ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 371);
            this.Controls.Add(this.groupBox_ResultadoDaBusca);
            this.Controls.Add(this.groupBox_FormaDeLista);
            this.MaximizeBox = false;
            this.Name = "Form_ListarClientes";
            this.Text = "Listar Clientes";
            this.groupBox_FormaDeLista.ResumeLayout(false);
            this.groupBox_FormaDeLista.PerformLayout();
            this.groupBox_ResultadoDaBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultadoDaBusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_FormaDeLista;
        private System.Windows.Forms.Button button_RealizarBusca;
        private System.Windows.Forms.Button button_CancelarLista;
        private System.Windows.Forms.RadioButton radioButton_ListaCompleta;
        private System.Windows.Forms.RadioButton radioButton_ListaPorLetra;
        private System.Windows.Forms.Label label_LetraParaBusca;
        private System.Windows.Forms.TextBox textBox_LetraParaBusca;
        private System.Windows.Forms.GroupBox groupBox_ResultadoDaBusca;
        private System.Windows.Forms.DataGridView dataGridView_ResultadoDaBusca;
        private System.Windows.Forms.Button button_NovaBusca;
        private System.Windows.Forms.Button button_AlterarClienteBusca;
    }
}