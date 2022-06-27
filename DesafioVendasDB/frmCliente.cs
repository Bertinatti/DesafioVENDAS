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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        public void limpaCampos()
        {
            tbCPF.Text = "";
            tbNomeCliente.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(tbCPF.Text, tbNomeCliente.Text, tbTelefone.Text, tbEmail.Text);
            bool retornaQuery = cliente.gravarCliente();
            if(retornaQuery)
            {
                MessageBox.Show("Cliente cadastrado com sucesso.", "CADASTRO - Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Falha no cadastro do cliente", "CADASTRO - Não efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }
        }
    }
}
