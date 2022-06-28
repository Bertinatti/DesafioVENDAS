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
        /// <summary>
        /// Método público para limpar os campos do formulário de cadastro de produto.
        /// </summary>
        public void limpaCampos()
        {
            tbCodigoBarras.Text = "";
            tbNomeProduto.Text = "";
            tbEstoque.Text = "";
            tbPreco.Text = "";
        }
        /// <summary>
        /// Cadastrando o produto no banco de dados.
        /// </summary>
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            // Cria o objeto da classe produto, define os valores e efetua a chamada do método para gravar o produto.
            Produto produto = new Produto(tbCodigoBarras.Text, tbNomeProduto.Text, decimal.Parse(tbPreco.Text), int.Parse(tbEstoque.Text));
            bool retornaQuery = produto.gravarProduto();
            // Verifica o retorno capturado no método de gravação de produto e verifica se a Query ocorreu seu erros.
            if (retornaQuery)
            {
                // Mensagem para caso a Query tenha sido executado sem erros.
                MessageBox.Show("Produto cadastrado com sucesso.", "CADASTRO - Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
            else
            {
                // Mensagem para caso a Query tenha sido executado com erros.
                MessageBox.Show("Falha no cadastro do produto", "CADASTRO - Não efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }
        }
    }
}
