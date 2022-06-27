using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    internal class Produto
    {
        private int idProduto;
        private string codigoBarras;
        private string nomeProduto;
        private decimal preco;
        private int estoque;

        public Produto(int idProduto, string codigoBarras, string nomeProduto, decimal preco, int estoque)
        {
            this.idProduto = idProduto;
            this.codigoBarras = codigoBarras;
            this.nomeProduto = nomeProduto;
            this.preco = preco;
            this.estoque = estoque;
        }

        public Produto(string codigoBarras, string nomeProduto, decimal preco, int estoque)
        {
            this.codigoBarras = codigoBarras;
            this.nomeProduto = nomeProduto;
            this.preco = preco;
            this.estoque = estoque;
        }

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public bool gravarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produto values (@codigo_barras, @nome_produto, @preco, @estoque);";
            command.Parameters.Add("@codigo_barras", SqlDbType.VarChar);
            command.Parameters.Add("@nome_produto", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Decimal);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = this.codigoBarras;
            command.Parameters[1].Value = this.nomeProduto;
            command.Parameters[2].Value = this.preco;
            command.Parameters[3].Value = this.estoque;
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
        public static bool deletarProduto(int idProduto)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM produto WHERE id_produto = @id_produto;";
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters[0].Value = idProduto;
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
        public static bool verificaEstoque(int idProduto, int quantidade)
        {
            int estoque = -1;
            Banco banco = new Banco();
            string sql = "SELECT estoque FROM produto where id_produto=" + idProduto +";";
            DataTable dt = banco.executarConsultaGenerica(sql);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        estoque = int.Parse(row[i].ToString());
                    }
                }
                if(estoque - quantidade >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool darBaixaEstoque(int idProduto, int quantidade)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update produto set estoque=estoque-" + quantidade +" where id_produto=" + idProduto +";";
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
