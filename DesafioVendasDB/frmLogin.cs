using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioGaragemDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public void verificaTipoUsuario(int tipo)
        {
            if(tipo == 0 || tipo == 1)
            {
                MessageBox.Show("Login efetuado com sucesso.", "Login efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipalVenda frmPrincipal = new frmPrincipalVenda();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login inválido.", "ERRO! - Login não efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int tipoUsuario = Usuario.efetuarLogin(tbLoginUsuario.Text, tbSenha.Text);
            verificaTipoUsuario(tipoUsuario);
        }

        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
