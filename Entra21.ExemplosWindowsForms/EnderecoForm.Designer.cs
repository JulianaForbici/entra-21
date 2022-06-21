namespace Entra21.ExemplosWindowsForms
{
    partial class EnderecoForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelEnderecos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maskedTextBoxENDERECOCOMPLETO = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(367, 312);
            this.dataGridView2.TabIndex = 1;
            // 
            // labelEnderecos
            // 
            this.labelEnderecos.AccessibleDescription = "";
            this.labelEnderecos.AutoSize = true;
            this.labelEnderecos.Location = new System.Drawing.Point(16, 16);
            this.labelEnderecos.Name = "labelEnderecos";
            this.labelEnderecos.Size = new System.Drawing.Size(61, 15);
            this.labelEnderecos.TabIndex = 2;
            this.labelEnderecos.Text = "Endereços";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 23);
            this.textBox1.TabIndex = 4;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(223, 5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(304, 5);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(617, 235);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(698, 235);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(401, 34);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.Tag = "";
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCEP_MaskInputRejected);
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(401, 6);
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCEP.TabIndex = 14;
            this.maskedTextBoxCEP.Text = "CEP";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // maskedTextBoxENDERECOCOMPLETO
            // 
            this.maskedTextBoxENDERECOCOMPLETO.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maskedTextBoxENDERECOCOMPLETO.Location = new System.Drawing.Point(401, 63);
            this.maskedTextBoxENDERECOCOMPLETO.Name = "maskedTextBoxENDERECOCOMPLETO";
            this.maskedTextBoxENDERECOCOMPLETO.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxENDERECOCOMPLETO.TabIndex = 16;
            this.maskedTextBoxENDERECOCOMPLETO.Text = "Endereço Completo";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(401, 135);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 17;
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBoxENDERECOCOMPLETO);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEnderecos);
            this.Controls.Add(this.dataGridView2);
            this.Name = "EnderecoForm";
            this.Text = "EnderecoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView2;
        private Label labelEnderecos;
        private TextBox textBox1;
        private Button buttonEditar;
        private Button buttonApagar;
        private ComboBox comboBox1;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBoxCEP;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox maskedTextBoxENDERECOCOMPLETO;
        private MaskedTextBox maskedTextBox2;
    }
}