using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsultorioMedico
{
    public partial class FrmMedicos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmMedicos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmLogin voltar = new FrmLogin();
            voltar.Show();
            this.Hide();
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            //executando o método carrega especialidades
            carregaCombo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncadEsc_Click(object sender, EventArgs e)
        {
            frmEspecialidades abrir = new frmEspecialidades();
            abrir.ShowDialog();
        }

        //Criando o método carrega especialidades
        public void carregaCombo()
        {
            cmbEspecialidadeMedicos.Items.Add("Clinico geral");
            cmbEspecialidadeMedicos.Items.Add("Cardiologista");
            cmbEspecialidadeMedicos.Items.Add("Dentista");
            cmbEspecialidadeMedicos.Items.Add("pediatrista");
            cmbEspecialidadeMedicos.Items.Add("Veterinário");

        }

        private void cmbEspecialidadeMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
