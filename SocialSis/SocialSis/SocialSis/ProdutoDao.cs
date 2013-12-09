using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SocialSis;

namespace Dao
{
    class ProdutoDao
    {
        public static readonly string TABELA = "produto";


        public static void salvar(Produto produto)
        {
            MySqlCommand cmd;
            string sql;

            if (produto.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @descricao, @precoUnitario);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    produto.Descricao);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@precoUnitario",
                    produto.PrecoUnitario);

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET descricao = @descricao, precoUnitario = @precoUnitario"
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    produto.Descricao);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@precoUnitario",
                    produto.PrecoUnitario);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    produto.GetId());
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }


        public static ArrayList buscarTodos(Produto produto)
        {
            // Reposta padrão.
            ArrayList produtos = null;

            // Cria uma coleção vazia.
            produtos = new ArrayList();

            MySqlCommand cmd;


            string sql = "SELECT * FROM " + TABELA + ";";

            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql,
                BancoDados.RecuperarConexao());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();

            // Enquanto houver items correspondentes...
            while (leitor.Read())
            {
                // adiciona o respectivo objeto item, construído
                // com os dados de retorno, à coleção de items.
                produtos.Add(
                    new Produto(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(), double.Parse(leitor["precoUnitario"].ToString())
                    )
                );
            }

            // Libera recursos de memória.
            leitor.Close();


            return produtos;
        }

        public static ArrayList buscarListaPorDescricao(Produto produto)
        {
            // Reposta padrão.
            ArrayList produtos = null;

            // Só é possível localizar uma item cuja descrição
            // esteja especificada.
            if (produto.Descricao != null)
            {
                // Cria uma coleção vazia.
                produtos = new ArrayList();

                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao LIKE @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    "%" + produto.Descricao + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    // adiciona o respectivo objeto cliente, construído
                    // com os dados de retorno, à coleção de items.
                    produtos.Add(
                      new Produto(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(), double.Parse(leitor["precoUnitario"].ToString())));


                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return produtos;
        }

        public static Produto buscarPorDescricao(Produto produto)
        {
            Produto resposta = null;

            if (produto.Descricao != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao LIKE @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    "%" + produto.Descricao + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Produto(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(), double.Parse(leitor["precoUnitario"].ToString())
                    );


                }
                leitor.Close();
            }


            return resposta;

        }

        public static void Excluir(Produto produto)
        {
            // Só é possível excluir uma tarefa cujo id
            // esteja especificado.
            if (produto.GetId() != 0)
            {
                MySqlCommand cmd;

                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                string sql = "DELETE FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    produto.GetId());

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }
    }
}
