using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    internal class Venda
    {
        private int idVenda;
        private int idCliente;
        private decimal valorTotal;
        /// <summary>
        /// Método construtor da classe Venda.
        /// </summary>
        /// <param name="idCliente">O Id do cliente, de tipo inteiro.</param>
        /// <param name="valorTotal">O valor total da venda, de tipo decimal.</param>
        public Venda(int idCliente, decimal valorTotal)
        {
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }
        /// <summary>
        /// Método construtor da classe Venda.
        /// </summary>
        /// <param name="idVenda">O Id da venda, de tipo inteiro.</param>
        /// <param name="idCliente">O Id do cliente, de tipo inteiro.</param>
        /// <param name="valorTotal">O valor total da venda, de tipo decimal.</param>
        public Venda(int idVenda, int idCliente, decimal valorTotal)
        {
            this.idVenda = idVenda;
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }
        /// <summary>
        /// Métodos getters e setters da classe Venda.
        /// </summary>
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
        /// <summary>
        /// Método público para gravar a Venda no banco de dados.
        /// </summary>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public bool gravarVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into venda values (@id_cliente, @valor_total);";
            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters.Add("@valor_total", SqlDbType.Decimal);
            command.Parameters[0].Value = this.idCliente;
            command.Parameters[1].Value = this.valorTotal;
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
        /// Método público e estático para deleter a Venda do banco de dados.
        /// </summary>
        /// <param name="idVenda">O Id da venda, de tipo inteiro.</param>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public static bool deletarVenda(int idVenda)
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
        /// <summary>
        /// Método público para retorna o valor do Id da venda que foi realizada por último.
        /// </summary>
        public void buscarIdVenda()
        {
            int id_venda = -1;
            Banco banco = new Banco();
            string sql = "SELECT MAX(id_venda) FROM venda;";
            DataTable dt = banco.executarConsultaGenerica(sql);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        id_venda = int.Parse(row[i].ToString());
                    }
                }
                this.idVenda = id_venda;
            }
        }
    }
}
