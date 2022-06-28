using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    internal class Usuario
    {
        private int idUsuario;
        private string login;
        private string senha;
        private string nomeUsuario;
        private int tipoUsuario;
        /// <summary>
        /// Método construtor da classe Usuário.
        /// </summary>
        /// <param name="login">O login do sistema, de tipo string.</param>
        /// <param name="senha">A senha do sistema, de tipo string.</param>
        /// <param name="nomeUsuario">O nome do usuário do sistema, de tipo string.</param>
        /// <param name="tipoUsuario">O tipo de usuário, de tipo inteiro.</param>
        public Usuario(string login, string senha, string nomeUsuario, int tipoUsuario)
        {
            this.login = login;
            this.senha = senha;
            this.nomeUsuario = nomeUsuario;
            this.tipoUsuario = tipoUsuario;
        }
        /// <summary>
        /// Método construtor da classe Usuário.
        /// </summary>
        /// <param name="idUsuario">O Id do usuário do sistema, de tipo inteiro.</param>
        /// <param name="login">O login do sistema, de tipo string.</param>
        /// <param name="senha">A senha do sistema, de tipo string.</param>
        /// <param name="nomeUsuario">O nome do usuário do sistema, de tipo string.</param>
        /// <param name="tipoUsuario">O tipo de usuário, de tipo inteiro.</param>
        public Usuario(int idUsuario, string login, string senha, string nomeUsuario, int tipoUsuario)
        {
            this.idUsuario = idUsuario;
            this.login = login;
            this.senha = senha;
            this.nomeUsuario = nomeUsuario;
            this.tipoUsuario = tipoUsuario;
        }
        /// <summary>
        /// Método privado que gera um login automático para o Usuário.
        /// </summary>
        /// <param name="nomeCompleto">Parâmetro contendo o nome do usuário do sistema, que será usado para gerar o login.</param>
        private void gerarLogin(string nomeCompleto)
        {
            string[] loginSplit = nomeCompleto.ToLower().Split(' ');
            string login = loginSplit[0] + "." + loginSplit[loginSplit.Length - 1];
            this.login = login;
        }
        /// <summary>
        /// Métodos getters e setters da classe Usuário.
        /// </summary>
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        /// <summary>
        /// Método para gravar o Usuário no banco de dados.
        /// </summary>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public bool gravarUsuario()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into usuario values (@login_usuario, @senha, @nome_usuario, @tipo_usuario);";
            command.Parameters.Add("@login_usuario", SqlDbType.VarChar);
            command.Parameters.Add("@senha", SqlDbType.VarChar);
            command.Parameters.Add("@nome_usuario", SqlDbType.VarChar);
            command.Parameters.Add("@tipo_usuario", SqlDbType.Int);
            command.Parameters[0].Value = this.login;
            command.Parameters[1].Value = this.senha;
            command.Parameters[2].Value = this.nomeUsuario;
            command.Parameters[3].Value = this.tipoUsuario;
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
        /// Método para deleter o Usuário do banco de dados. 
        /// </summary>
        /// <param name="idUsuario">O Id do usuário que será deletado, de tipo inteiro.</param>
        /// <returns>Retorna verdadeiro quando a Query é executada com sucesso.</returns>
        public static bool deletarUsuario(int idUsuario)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM usuario WHERE id_usuario = @id_usuario;";
            command.Parameters.Add("@id_usuario", SqlDbType.Int);
            command.Parameters[0].Value = idUsuario;
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
        /// Método público e estático para verificar o login.
        /// </summary>
        /// <param name="login">Parâmetro que recebe o valor do login, de tipo string.</param>
        /// <param name="senha">Parâmetro que recebe o valor da senha, de tipo string.</param>
        /// <returns>Retorna o nível do Usuário do sistema, de tipo inteiro.</returns>
        public static int efetuarLogin(string login, string senha)
        {
            int tipoUsuario = -1;
            Banco banco = new Banco();
            string sql = "select tipo_usuario from usuario where login_usuario='" + login + "' and senha='" + senha + "';";
            DataTable dt = banco.executarConsultaGenerica(sql);
            if (dt.Rows.Count == 1)
            {
                foreach(DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        tipoUsuario = int.Parse(row[i].ToString());
                    }
                }
                return tipoUsuario;
            }
            else
            {
                return -1;
            }
        }
    }
}
