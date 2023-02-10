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
    public partial class FrmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = texUsuario.Text;
            senha = texSenha.Text;

            if (usuario.Equals("senac") && senha.Equals("senac"))
            {
                //abrir outra janela
                FrmMenuPrincipal abrir = new FrmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!!!", "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                //Limpando a text
                texUsuario.Text = "";
                texSenha.Clear();
                texUsuario.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Close();
            //this.Close();
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void texUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                texSenha.Focus();
            }
        }

        private void texSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntar.Focus();
            }
        }
    }
}
