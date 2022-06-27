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

namespace DesafioGaragemDB
{
    public partial class frmPrincipalVenda : Form
    {
        public frmPrincipalVenda()
        {
            InitializeComponent();
        }
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirForms(object formAberto)
        {
            if (this.pConteudo.Controls.Count > 0)
                this.pConteudo.Controls.RemoveAt(0);
            Form novoForm = formAberto as Form;
            novoForm.TopLevel = false;
            novoForm.Dock = DockStyle.Fill;
            this.pConteudo.Controls.Add(novoForm);
            this.pConteudo.Tag = novoForm;
            novoForm.Show();
        }

        private void btnInicioSistema_Click(object sender, EventArgs e)
        {
        }

        private void frmPrincipalVenda_Load(object sender, EventArgs e)
        {
            btnInicioSistema_Click(null, e);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirForms(new frmCliente());
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            abrirForms(new frmProduto());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            abrirForms(new frmVenda());
        }
    }
}
