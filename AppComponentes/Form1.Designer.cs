
namespace AppComponentes
{
    partial class FrmComponentes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.texNome = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lstListagem = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.cbbLista = new System.Windows.Forms.ComboBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(122, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "insira seu nome";
            // 
            // texNome
            // 
            this.texNome.Location = new System.Drawing.Point(113, 88);
            this.texNome.Name = "texNome";
            this.texNome.Size = new System.Drawing.Size(100, 20);
            this.texNome.TabIndex = 1;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(113, 148);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // lstListagem
            // 
            this.lstListagem.FormattingEnabled = true;
            this.lstListagem.Location = new System.Drawing.Point(113, 206);
            this.lstListagem.Name = "lstListagem";
            this.lstListagem.Size = new System.Drawing.Size(120, 95);
            this.lstListagem.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(125, 358);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(270, 362);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(45, 17);
            this.ckbLivro.TabIndex = 5;
            this.ckbLivro.Text = "livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(303, 206);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(100, 94);
            this.pctImagem.TabIndex = 6;
            this.pctImagem.TabStop = false;
            // 
            // cbbLista
            // 
            this.cbbLista.FormattingEnabled = true;
            this.cbbLista.Location = new System.Drawing.Point(303, 166);
            this.cbbLista.Name = "cbbLista";
            this.cbbLista.Size = new System.Drawing.Size(121, 21);
            this.cbbLista.TabIndex = 7;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(381, 361);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(72, 17);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // FrmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.cbbLista);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstListagem);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmComponentes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox texNome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ListBox lstListagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.ComboBox cbbLista;
        private System.Windows.Forms.RadioButton rdbMasculino;
    }
}

