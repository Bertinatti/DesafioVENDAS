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
        /// <summary>
        /// Método público que verifica o tipo de usuário que efetuou o login - não implementado.
        /// </summary>
        /// <param name="tipo">Nível do Usuário do sistema, de tipo inteiro.</param>
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
        // Botão de efetuar login, que efetua o login e recebe o nível do usuário do sistema para caso seja efetuado o login com sucesso.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int tipoUsuario = Usuario.efetuarLogin(tbLoginUsuario.Text, tbSenha.Text);
            verificaTipoUsuario(tipoUsuario);
        }
        // Botão que fecha a aplicação. 
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Botão que maximiza a aplicação.
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        // Botão que restaura a aplicação.
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        // Botão que minimiza a aplicação.
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
