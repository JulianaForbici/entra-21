namespace Entra21.BancoDados01.Ado.Nett.Views.TiposPersonagens
{
    partial class TipoPersonagemListagemForm
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewTipoPersonagem = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(423, 31);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(623, 31);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(523, 31);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTipoPersonagem
            // 
            this.dataGridViewTipoPersonagem.AllowUserToAddRows = false;
            this.dataGridViewTipoPersonagem.AllowUserToDeleteRows = false;
            this.dataGridViewTipoPersonagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoPersonagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTipo});
            this.dataGridViewTipoPersonagem.Location = new System.Drawing.Point(51, 79);
            this.dataGridViewTipoPersonagem.Name = "dataGridViewTipoPersonagem";
            this.dataGridViewTipoPersonagem.ReadOnly = true;
            this.dataGridViewTipoPersonagem.RowHeadersWidth = 51;
            this.dataGridViewTipoPersonagem.RowTemplate.Height = 29;
            this.dataGridViewTipoPersonagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTipoPersonagem.Size = new System.Drawing.Size(683, 348);
            this.dataGridViewTipoPersonagem.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.MinimumWidth = 6;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            this.ColumnTipo.Width = 125;
            // 
            // TipoPersonagemListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTipoPersonagem);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "TipoPersonagemListagemForm";
            this.Text = "TipoPersonagemListagemForm";
            this.Load += new System.EventHandler(this.TipoPersonagemListagemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoPersonagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonApagar;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private DataGridView dataGridViewTipoPersonagem;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTipo;
    }
}