using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;

namespace Dao
{
    class InsumoDao
    {
        public static readonly string TABELA = "insumo";


        public static void Salvar(Insumo insumo)
        {
            MySqlCommand cmd;
            string sql;

            if (insumo.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @descricao, @precoUnitario);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    insumo.Descricao);

                cmd.Parameters.AddWithValue("@precoUnitario",
                    insumo.PrecoUnitario);

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
                    insumo.Descricao);

                cmd.Parameters.AddWithValue("@id",
                    insumo.GetId());

                cmd.Parameters.AddWithValue("@precoUnitario",
                    insumo.PrecoUnitario);
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }


        public static ArrayList BuscarTodos(Insumo insumo)
        {
            // Reposta padrão.
            ArrayList insumos = null;

            // Cria uma coleção vazia.
            insumos = new ArrayList();

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
                insumos.Add(
                    new Insumo(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(), 
                        double.Parse(leitor["precoUnitario"].ToString())
                    )
                );
            }

            // Libera recursos de memória.
            leitor.Close();


            return insumos;
        }

        public static ArrayList BuscarListaPorDescricao(Insumo insumo)
        {
            // Reposta padrão.
            ArrayList insumos = null;

            // Só é possível localizar uma item cuja descrição
            // esteja especificada.
            if (insumo.Descricao != null)
            {
                // Cria uma coleção vazia.
                insumos = new ArrayList();

                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao LIKE @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    "%" + insumo.Descricao + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    // adiciona o respectivo objeto cliente, construído
                    // com os dados de retorno, à coleção de items.
                    insumos.Add(
                      new Insumo(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(),
                        double.Parse(leitor["precoUnitario"].ToString())));

                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return insumos;
        }

        public static Insumo BuscarPorDescricao(Insumo insumo)
        {
            Insumo resposta = null;

            if (insumo.Descricao != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao LIKE @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    "%" + insumo.Descricao + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Insumo(
                        int.Parse(leitor["id"].ToString()),
                        leitor["descricao"].ToString(),
                        double.Parse(leitor["precoUnitario"].ToString())
                    );


                }
                leitor.Close();
            }


            return resposta;

        }

        public static void Excluir(Insumo insumo)
        {
            // Só é possível excluir uma tarefa cujo id
            // esteja especificado.
            if (insumo.GetId() != 0)
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
                    insumo.GetId());

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }
    }
}
