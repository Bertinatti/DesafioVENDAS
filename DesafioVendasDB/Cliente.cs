using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    internal class Cliente
    {
        private int idCliente;
        private string cpf;
        private string nomeCliente;
        private string telefone;
        private string email;
        /// <summary>
        /// Método construtor da classe Cliente.
        /// </summary>
        /// <param name="idCliente">O Id do cliente, de tipo string.</param>
        /// <param name="cpf">O CPF do cliente, de tipo string.</param>
        /// <param name="nomeCliente">O Nome do cliente, de tipo string.</param>
        /// <param name="telefone">O telefone do cliente, de tipo string.</param>
        /// <param name="email">O e-mail do cliente, de tipo string.</param>
        public Cliente(int idCliente, string cpf, string nomeCliente, string telefone, string email)
        {
            this.idCliente = idCliente;
            this.cpf = cpf;
            this.nomeCliente = nomeCliente;
            this.telefone = telefone;
            this.email = email;
        }
        /// <summary>
        /// Método construtor da classe Cliente.
        /// </summary>
        /// <param name="cpf">O CPF do cliente, de tipo string.</param>
        /// <param name="nomeCliente">O Nome do cliente, de tipo string.</param>
        /// <param name="telefone">O telefone do cliente, de tipo string.</param>
        /// <param name="email">O e-mail do cliente, de tipo string.</param>
        public Cliente(string cpf, string nomeCliente, string telefone, string email)
        {
            this.cpf = cpf;
            this.nomeCliente = nomeCliente;
            this.telefone = telefone;
            this.email = email;
        }
        /// <summary>
        /// Métodos getters e setters da classe Cliente.
        /// </summary>
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Método público para gravar o Cliente no banco de dados.
        /// </summary>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into cliente values (@cpf, @nome_cliente, @telefone, @email);";
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome_cliente", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = this.cpf;
            command.Parameters[1].Value = this.nomeCliente;
            command.Parameters[2].Value = this.telefone;
            command.Parameters[3].Value = this.email;
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
        /// Método público e estático para deleter o Cliente do banco de dados.
        /// </summary>
        /// <param name="idCliente">O Id do cliente que será deletado, de tipo inteiro.</param>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public static bool deletarCliente(int idCliente)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM cliente WHERE id_cliente = @id_cliente;";
            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters[0].Value = idCliente;
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
