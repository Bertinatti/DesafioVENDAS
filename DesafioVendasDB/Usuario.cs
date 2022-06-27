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

        public Usuario(string login, string senha, string nomeUsuario, int tipoUsuario)
        {
            this.login = login;
            this.senha = senha;
            this.nomeUsuario = nomeUsuario;
            this.tipoUsuario = tipoUsuario;
        }

        public Usuario(int idUsuario, string login, string senha, string nomeUsuario, int tipoUsuario)
        {
            this.idUsuario = idUsuario;
            this.login = login;
            this.senha = senha;
            this.nomeUsuario = nomeUsuario;
            this.tipoUsuario = tipoUsuario;
        }
        private void gerarLogin(string nomeCompleto)
        {
            string[] loginSplit = nomeCompleto.ToLower().Split(' ');
            string login = loginSplit[0] + "." + loginSplit[loginSplit.Length - 1];
            this.login = login;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

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
