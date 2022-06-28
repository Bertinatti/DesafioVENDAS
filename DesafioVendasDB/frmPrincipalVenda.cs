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
        // Botao de fechar aplicação.
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Botão de minimizar a aplicação.
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Botao de maximizar a aplicação.
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        // Botão de restaurar a aplicação.
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        // Botão de sair da aplicação.
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Método para instância o formulário no container de conteúdo.
        /// </summary>
        /// <param name="formAberto">Parâmetro que recebe o nome do formulário que será instanciado</param>
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
        // Botão para abrir a tela inicial.
        private void btnInicioSistema_Click(object sender, EventArgs e)
        {
        }
        // O carregamento do formulário principal que está chamando o clique do botão de início de sistema.
        private void frmPrincipalVenda_Load(object sender, EventArgs e)
        {
            btnInicioSistema_Click(null, e);
        }
        // Botão para abrir o formulário de cadastro de clientes.
        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirForms(new frmCliente());
        }
        // Botão para abrir o formulário de cadastro de produtos.
        private void btnProduto_Click(object sender, EventArgs e)
        {
            abrirForms(new frmProduto());
        }
        // Botão para abrir o formulário de cadastro de vendas.
        private void btnCompra_Click(object sender, EventArgs e)
        {
            abrirForms(new frmVenda());
        }
    }
}
