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

        public Item(int idVenda, int idProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idVenda = idVenda;
            this.idProduto = idProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }

        public Item(int idItemVenda, int idVenda, int idProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idItemVenda = idItemVenda;
            this.idVenda = idVenda;
            this.idProduto = idProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }

        public Item(int idProduto, string nomeProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.idProduto = idProduto;
            this.NomeProduto = nomeProduto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;
        }

        public int IdItemVenda { get => idItemVenda; set => idItemVenda = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public decimal ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }

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
        public static bool deletarProduto(int idVenda)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM venda WHERE id_venda = @id_venda;";
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters[0].Value = idVenda;
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
