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
        private void popularDataGridCarrinho(List<Item> lista)
        {
            dgCarrinho.Rows.Clear();
            foreach (Item i in lista)
            {
                dgCarrinho.Rows.Add(i.IdProduto, i.NomeProduto, i.ValorUnitario, i.Quantidade, i.ValorTotal);
            }
        }
        private void somaValorTotal(List<Item> lista)
        {
            valorVenda = 0;
            foreach (Item i in lista)
            {
                valorVenda += i.ValorTotal;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            bool retornaQueryVenda, retornaQueryItem, retornaQueryBaixaEstoque;
            int contaFalha = 0;
            int contaFalhaBaixaEstoque = 0;
           DialogResult = MessageBox.Show("Deseja finalizar a compra?", "CUIDADO - A compra será finalizada.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                somaValorTotal(listaItensVenda);
                Venda v = new Venda(idCliente, valorVenda);
                retornaQueryVenda = v.gravarVenda();
                v.buscarIdVenda();
                idVenda = v.IdVenda;
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
                if(retornaQueryVenda && contaFalha == 0 && contaFalhaBaixaEstoque == 0)
                {
                    MessageBox.Show("Compra realizada com sucesso.", "COMPRA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgCarrinho.Rows.Clear();
                    btnSelecionaUsuario.Enabled = true;
                    cbNomeCliente.Enabled = true;
                    tbQuantidade.Text = "";
                    this.produtoTableAdapter.Fill(this.caboclo_dbDataSet.produto);
                }
                else
                {
                    MessageBox.Show("Erro na compra.", "COMPRA NÃO REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgCarrinho.Rows.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Compra foi encerrada.", "COMPRA ENCERRADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgCarrinho.Rows.Clear();
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

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduto = int.Parse(dgProdutos.CurrentRow.Cells[0].Value.ToString());
        }


        private void btnSelecionaUsuario_Click(object sender, EventArgs e)
        {
            idCliente = int.Parse(cbNomeCliente.SelectedValue.ToString());
            btnSelecionaUsuario.Enabled = false;
            cbNomeCliente.Enabled = false;
            btnAdicionarItem.Enabled = true;
        }

        List<Item> listaItensVenda = new List<Item>();
        int idCliente;
        int idVenda;
        int idProduto;
        string nomeProduto;
        decimal valorVenda;

    }
}
