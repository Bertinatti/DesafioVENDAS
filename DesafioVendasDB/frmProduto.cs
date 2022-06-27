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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        public void limpaCampos()
        {
            tbCodigoBarras.Text = "";
            tbNomeProduto.Text = "";
            tbEstoque.Text = "";
            tbPreco.Text = "";
        }
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(tbCodigoBarras.Text, tbNomeProduto.Text, decimal.Parse(tbPreco.Text), int.Parse(tbEstoque.Text));
            bool retornaQuery = produto.gravarProduto();
            if (retornaQuery)
            {
                MessageBox.Show("Produto cadastrado com sucesso.", "CADASTRO - Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Falha no cadastro do produto", "CADASTRO - Não efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }
        }
    }
}
