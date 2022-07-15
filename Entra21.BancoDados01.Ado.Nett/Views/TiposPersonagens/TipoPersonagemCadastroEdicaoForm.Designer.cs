namespace Entra21.BancoDados01.Ado.Nett.Views.TiposPersonagens
{
    partial class TipoPersonagemCadastroEdicaoForm
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
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 19);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(39, 20);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(267, 114);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(105, 44);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(395, 114);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 44);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(12, 60);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(506, 27);
            this.textBoxTipo.TabIndex = 3;
            // 
            // TipoPersonagemCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 193);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelTipo);
            this.Name = "TipoPersonagemCadastroEdicaoForm";
            this.Text = "TipoPersonagemCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTipo;
        private Button buttonEditar;
        private Button buttonSalvar;
        private TextBox textBoxTipo;
    }
}