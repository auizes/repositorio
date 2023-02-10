
namespace ConsultorioMedico
{
    partial class frmEspecialidades
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
            this.btnVoltarMedicos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoMedicos = new System.Windows.Forms.TextBox();
            this.txtNomemedicosEs = new System.Windows.Forms.TextBox();
            this.lblNomeCodigolMedicos = new System.Windows.Forms.Label();
            this.lblCodigoMedicos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarMedicos
            // 
            this.btnVoltarMedicos.Location = new System.Drawing.Point(606, 327);
            this.btnVoltarMedicos.Name = "btnVoltarMedicos";
            this.btnVoltarMedicos.Size = new System.Drawing.Size(131, 42);
            this.btnVoltarMedicos.TabIndex = 4;
            this.btnVoltarMedicos.Text = "&Voltar";
            this.btnVoltarMedicos.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(606, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "&Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodigoMedicos
            // 
            this.txtCodigoMedicos.Location = new System.Drawing.Point(27, 125);
            this.txtCodigoMedicos.Name = "txtCodigoMedicos";
            this.txtCodigoMedicos.Size = new System.Drawing.Size(288, 20);
            this.txtCodigoMedicos.TabIndex = 24;
            // 
            // txtNomemedicosEs
            // 
            this.txtNomemedicosEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomemedicosEs.Location = new System.Drawing.Point(25, 205);
            this.txtNomemedicosEs.MaxLength = 50;
            this.txtNomemedicosEs.Name = "txtNomemedicosEs";
            this.txtNomemedicosEs.Size = new System.Drawing.Size(290, 24);
            this.txtNomemedicosEs.TabIndex = 19;
            // 
            // lblNomeCodigolMedicos
            // 
            this.lblNomeCodigolMedicos.AutoSize = true;
            this.lblNomeCodigolMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCodigolMedicos.Location = new System.Drawing.Point(25, 178);
            this.lblNomeCodigolMedicos.Name = "lblNomeCodigolMedicos";
            this.lblNomeCodigolMedicos.Size = new System.Drawing.Size(49, 18);
            this.lblNomeCodigolMedicos.TabIndex = 18;
            this.lblNomeCodigolMedicos.Text = "Nome";
            // 
            // lblCodigoMedicos
            // 
            this.lblCodigoMedicos.AutoSize = true;
            this.lblCodigoMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMedicos.Location = new System.Drawing.Point(24, 92);
            this.lblCodigoMedicos.Name = "lblCodigoMedicos";
            this.lblCodigoMedicos.Size = new System.Drawing.Size(56, 18);
            this.lblCodigoMedicos.TabIndex = 16;
            this.lblCodigoMedicos.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Especialidades";
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoMedicos);
            this.Controls.Add(this.txtNomemedicosEs);
            this.Controls.Add(this.lblNomeCodigolMedicos);
            this.Controls.Add(this.lblCodigoMedicos);
            this.Controls.Add(this.btnVoltarMedicos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEspecialidades";
            this.Load += new System.EventHandler(this.lblEspecialidadecodi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarMedicos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigoMedicos;
        private System.Windows.Forms.TextBox txtNomemedicosEs;
        private System.Windows.Forms.Label lblNomeCodigolMedicos;
        private System.Windows.Forms.Label lblCodigoMedicos;
        private System.Windows.Forms.Label label1;
    }
}