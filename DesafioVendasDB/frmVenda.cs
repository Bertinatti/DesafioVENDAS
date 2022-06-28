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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método público para popular o DataGrid carrinho de compras.
        /// </summary>
        /// <param name="lista">Lista com os itens da venda.</param>
        private void popularDataGridCarrinho(List<Item> lista)
        {
            dgCarrinho.Rows.Clear();
            foreach (Item i in lista)
            {
                dgCarrinho.Rows.Add(i.IdProduto, i.NomeProduto, i.ValorUnitario, i.Quantidade, i.ValorTotal);
            }
        }
        /// <summary>
        /// Método público para cálcular o valor total da compra.
        /// </summary>
        /// <param name="lista">Lista com os itens da venda.</param>
        private void somaValorTotal(List<Item> lista)
        {
            valorVenda = 0;
            foreach (Item i in lista)
            {
                valorVenda += i.ValorTotal;
            }
        }
        /// <summary>
        /// Cadastrando a venda e os itens da venda no banco de dados.
        /// </summary>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Variáveis auxiliares na gravação dos dados.
            bool retornaQueryVenda, retornaQueryItem, retornaQueryBaixaEstoque;
            int contaFalha = 0;
            int contaFalhaBaixaEstoque = 0;
            // Verifica se o usuário clicou no botão "sim" para continuar com a compra.
            DialogResult = MessageBox.Show("Deseja finalizar a compra?", "CUIDADO - A compra será finalizada.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                // Soma o valor total da venda, cria o objeto da classe venda, define os valores e efetua a chamada do método para gravar a venda.
                somaValorTotal(listaItensVenda);
                Venda v = new Venda(idCliente, valorVenda);
                // Efetua a gravação dos dados e captura o retorno do método.
                retornaQueryVenda = v.gravarVenda();
                v.buscarIdVenda();
                // Salva o valor do id da venda na variável global.
                idVenda = v.IdVenda;
                // Efetua a gravação de todos os itens da lista.
                foreach (Item i in listaItensVenda)
                {
                    Item novoItem = new Item(idVenda, i.IdProduto, i.ValorUnitario, i.Quantidade, i.ValorTotal);
                    retornaQueryItem = novoItem.gravarItem();
                    retornaQueryBaixaEstoque = Produto.darBaixaEstoque(i.IdProduto, i.Quantidade);
                    if(!retornaQueryItem)
                    {
                        contaFalha++;
                    }
                    if(!retornaQueryBaixaEstoque)
                    {
                        contaFalhaBaixaEstoque++;
                    }
                }
                // Verifica se a venda foi gravada com sucesso
                if(retornaQueryVenda && contaFalha == 0 && contaFalhaBaixaEstoque == 0)
                {
                    MessageBox.Show("Compra realizada com sucesso.", "COMPRA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgCarrinho.Rows.Clear();
                    listaItensVenda.Clear();
                    btnSelecionaUsuario.Enabled = true;
                    cbNomeCliente.Enabled = true;
                    tbQuantidade.Text = "";
                    this.produtoTableAdapter.Fill(this.caboclo_dbDataSet.produto);                   
                }
                else
                {
                    MessageBox.Show("Erro na compra.", "COMPRA NÃO REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgCarrinho.Rows.Clear();
                    listaItensVenda.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Compra foi encerrada.", "COMPRA ENCERRADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgCarrinho.Rows.Clear();
                listaItensVenda.Clear();
                tbQuantidade.Text = "";
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'caboclo_dbDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.caboclo_dbDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'caboclo_dbDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.caboclo_dbDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'caboclo_dbDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.caboclo_dbDataSet.cliente);

        }
        /// <summary>
        /// Salva os dados do DataGrid do carrinho e na lista de itens da venda.
        /// </summary>
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            
            int quantidade = 0;
            decimal valorTotal = 0;
            decimal valorUnitario = 0;
            if (int.TryParse(tbQuantidade.Text, out quantidade))
            {
                bool retornaQuery = Produto.verificaEstoque(idProduto, quantidade);
                if (retornaQuery)
                {
                    //MessageBox.Show("Estoque suficiente para suprir a demanda.", "ESTOQUE - Quantidade necessária.", MessageBoxButtons.OK);
                    nomeProduto = dgProdutos.CurrentRow.Cells[2].Value.ToString();
                    valorUnitario = decimal.Parse(dgProdutos.CurrentRow.Cells[3].Value.ToString());
                    valorTotal = (decimal)quantidade * valorUnitario;
                    Item i = new Item(idProduto, nomeProduto, valorUnitario, quantidade, valorTotal);
                    listaItensVenda.Add(i);
                    popularDataGridCarrinho(listaItensVenda);
                }
                else
                {
                    //MessageBox.Show("Estoque insuficiente para suprir a demanda.", "ESTOQUE - Quantidade insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnComprar.Enabled = true;
                tbQuantidade.Text = "";
            }
            else
            {
                MessageBox.Show("Quantidade inválida", "ERRO! - Quantidade.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantidade.Text = "";
                tbQuantidade.Focus();
            }
            
            
        }
        /// <summary>
        /// Captura do DataGrid de Produtos o id do produto, que está vindo do banco.
        /// </summary>
        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduto = int.Parse(dgProdutos.CurrentRow.Cells[0].Value.ToString());
        }

        // Botão para confirmar o usuário que efetuará a compra.
        private void btnSelecionaUsuario_Click(object sender, EventArgs e)
        {
            idCliente = int.Parse(cbNomeCliente.SelectedValue.ToString());
            btnSelecionaUsuario.Enabled = false;
            cbNomeCliente.Enabled = false;
            btnAdicionarItem.Enabled = true;
        }

        /// <summary>
        /// Variáveis globais que serão utilizadas na gravação dos dados. 
        /// </summary>
        List<Item> listaItensVenda = new List<Item>();
        int idCliente;
        int idVenda;
        int idProduto;
        string nomeProduto;
        decimal valorVenda;

    }
}
