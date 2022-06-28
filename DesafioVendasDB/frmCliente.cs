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
        /// <summary>
        /// Método público que limpa os campos do formulário de cadastro de clientes.
        /// </summary>
        public void limpaCampos()
        {
            tbCPF.Text = "";
            tbNomeCliente.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
        }
        /// <summary>
        /// Cadastrando o cliente no banco de dados.
        /// </summary>
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            // Cria o objeto da classe cliente, define os valores e efetua a chamada do método para gravar o cliente.
            Cliente cliente = new Cliente(tbCPF.Text, tbNomeCliente.Text, tbTelefone.Text, tbEmail.Text);
            bool retornaQuery = cliente.gravarCliente();
            // Verifica o retorno capturado no método de gravação de cliente e verifica se a Query ocorreu seu erros.
            if (retornaQuery)
            {
                // Mensagem para caso a Query tenha sido executado sem erros.
                MessageBox.Show("Cliente cadastrado com sucesso.", "CADASTRO - Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampos();
            }
            else
            {
                // Mensagem para caso a Query tenha sido executado com erros.
                MessageBox.Show("Falha no cadastro do cliente", "CADASTRO - Não efetuado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }
        }
    }
}
