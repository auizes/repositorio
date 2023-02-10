
namespace ConsultorioMedico
{
    partial class FrmVacina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltarVacina = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltarVacina);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 121);
            this.panel1.TabIndex = 1;
            // 
            // btnVoltarVacina
            // 
            this.btnVoltarVacina.Location = new System.Drawing.Point(624, 44);
            this.btnVoltarVacina.Name = "btnVoltarVacina";
            this.btnVoltarVacina.Size = new System.Drawing.Size(130, 48);
            this.btnVoltarVacina.TabIndex = 4;
            this.btnVoltarVacina.Text = "&Voltar";
            this.btnVoltarVacina.UseVisualStyleBackColor = true;
            this.btnVoltarVacina.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "&Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVacina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacina";
            this.Load += new System.EventHandler(this.FrmVacina_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltarVacina;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}