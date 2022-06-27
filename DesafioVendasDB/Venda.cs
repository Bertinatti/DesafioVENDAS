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

        public Venda(int idCliente, decimal valorTotal)
        {
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }

        public Venda(int idVenda, int idCliente, decimal valorTotal)
        {
            this.idVenda = idVenda;
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }

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
