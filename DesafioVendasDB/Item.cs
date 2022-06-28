using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    internal class Item
    {
        private int idItemVenda;
        private int idVenda;
        private int idProduto;
        private string nomeProduto;
        private decimal valorUnitario;
        private int quantidade;
        private decimal valorTotal;
        /// <summary>
        /// Método construtor da classe Item.
        /// </summary>
        /// <param name="idVenda">O Id da venda realizada, de tipo inteiro.</param>
        /// <param name="idProduto">O Id do produto vendido, de tipo inteiro.</param>
        /// <param name="valorUnitario">O valor unitário do produto vendido, de tipo decimal.</param>
        /// <param name="quantidade">A quantidade de produtos vendidos, de tipo inteiro.</param>
        /// <param name="valorTotal">O valor total da venda realizada, de tipo decimal.</param>
        public Item(int idVenda, int idProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idVenda = idVenda;
            this.idProduto = idProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }
        /// <summary>
        /// Método construtor da classe Item.
        /// </summary>
        /// <param name="idItemVenda">O Id do item vendido, de tipo inteiro.</param>
        /// <param name="idVenda">O Id da venda realizada, de tipo inteiro.</param>
        /// <param name="idProduto">O Id do produto vendido, de tipo inteiro.</param>
        /// <param name="valorUnitario">O valor unitário do produto vendido, de tipo decimal.</param>
        /// <param name="quantidade">A quantidade de produtos vendidos, de tipo inteiro.</param>
        /// <param name="valorTotal">O valor total da venda realizada, de tipo decimal.</param>
        public Item(int idItemVenda, int idVenda, int idProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idItemVenda = idItemVenda;
            this.idVenda = idVenda;
            this.idProduto = idProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }
        /// <summary>
        /// Método construtor da classe Item.
        /// </summary>
        /// <param name="idProduto">O Id do produto vendido, de tipo inteiro.</param>
        /// <param name="nomeProduto">O nome do produto vendido, de tipo string.</param>
        /// <param name="valorUnitario">O valor unitário do produto vendido, de tipo decimal.</param>
        /// <param name="quantidade">A quantidade de produtos vendidos, de tipo inteiro.</param>
        /// <param name="valorTotal">O valor total da venda realizada, de tipo decimal.</param>
        public Item(int idProduto, string nomeProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idProduto = idProduto;
            this.NomeProduto = nomeProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }
        /// <summary>
        /// Métodos getters e setters da classe Item.
        /// </summary>
        public int IdItemVenda { get => idItemVenda; set => idItemVenda = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public decimal ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
        /// <summary>
        /// Método público para gravar os dados no banco de dados.
        /// </summary>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public bool gravarItem()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into item_venda values (@id_venda, @id_produto, @valor_unitario, @quantidade, @valor_total);";
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters.Add("@valor_unitario", SqlDbType.Decimal);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@valor_total", SqlDbType.Decimal);
            command.Parameters[0].Value = this.idVenda;
            command.Parameters[1].Value = this.IdProduto;
            command.Parameters[2].Value = this.valorUnitario;
            command.Parameters[3].Value = this.quantidade;
            command.Parameters[4].Value = this.ValorTotal;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
        /// <summary>
        /// Método público e estático para deleter 
        /// </summary>
        /// <param name="idItemVenda">O Id do Item da venda, de tipo inteiro.</param>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public static bool deletarItem(int idItemVenda)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM item_venda WHERE id_item_venvenda = @id_item_venda;";
            command.Parameters.Add("@id_item_venda", SqlDbType.Int);
            command.Parameters[0].Value = idItemVenda;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
