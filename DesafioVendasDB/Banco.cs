using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioGaragemDB
{
    public class Banco
    {
        /// <summary>
        /// String de conexão do banco de dados local com a aplicação.
        /// </summary>
        string stringConexao = "Data Source=localhost;Initial Catalog=caboclo_db;TrustServerCertificate=True;Integrated Security=True";

        private SqlConnection cn;
        /// <summary>
        /// Método para efetuar a conexão no banco de dados.
        /// </summary>
        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }
        /// <summary>
        /// Método para abrir a conexão.
        /// </summary>
        /// <returns>Retorna a conexão ou um valor nulo.</returns>
        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }
        /// <summary>
        /// Método para fechar a conexão.
        /// </summary>
        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// Método para executar uma consulta genérica no banco de dados.
        /// </summary>
        /// <param name="sql">String de pesquisa no banco de dados.</param>
        /// <returns>Retorna o resultado da pesquisa.</returns>
        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
