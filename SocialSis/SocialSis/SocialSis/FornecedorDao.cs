using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SocialSis;

namespace Dao
{
    class FornecedorDao
    {
        public static readonly string TABELA = "fornecedor";


        public static void salvar(Fornecedor fornecedor)
        {
            MySqlCommand cmd;
            string sql;


            sql = "INSERT INTO " + TABELA
                + " VALUES (@cnpj, @tel, @email, @nome, @endereco);";

            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql,
                BancoDados.RecuperarConexao());

            // Inserção de valores nos parâmetros.
            cmd.Parameters.AddWithValue("@cnpj",
                fornecedor.Cnpj);

            cmd.Parameters.AddWithValue("@endereco",
                fornecedor.Endereco);

            cmd.Parameters.AddWithValue("@nome",
                fornecedor.Nome);

            cmd.Parameters.AddWithValue("@email",
                fornecedor.Email);

            cmd.Parameters.AddWithValue("@tel",
                fornecedor.Tel);



            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

        public static ArrayList BuscarTodos()
        {
            // Reposta padrão.
            ArrayList fornecedores = new ArrayList();

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

            // Enquanto houver clientes correspondentes...
            while (leitor.Read())
            {
                // adiciona o respectivo objeto item, construído
                // com os dados de retorno, à coleção de items.
                fornecedores.Add(
                    new Fornecedor(
                         ulong.Parse(leitor["cnpj"].ToString()), 
                         leitor["nome"].ToString(),
                         leitor["endereco"].ToString(),
                         leitor["email"].ToString(), 
                         leitor["tel"].ToString()
                        ));


            }

            // Libera recursos de memória.
            leitor.Close();


            return fornecedores;
        }

        public static Fornecedor BuscarPorNome(Fornecedor fornecedor)
        {
            Fornecedor resposta = null;

            if (fornecedor.Nome != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome LIKE @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    "%" + fornecedor.Nome + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Fornecedor(
                         ulong.Parse(leitor["cnpj"].ToString()), leitor["nome"].ToString(), leitor["endereco"].ToString(),
                         leitor["email"].ToString(), leitor["tel"].ToString()
                         );

                }
                leitor.Close();


            }
            return resposta;
        }

        public static ArrayList BuscarListaPorNome(Fornecedor fornecedor)
        {
            // Reposta padrão.
            ArrayList fornecedores = null;

            // Só é possível localizar uma item cuja descrição
            // esteja especificada.
            if (fornecedor.Nome != null)
            {
                // Cria uma coleção vazia.
                fornecedores = new ArrayList();

                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome LIKE @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    "%" + fornecedor.Nome + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    // adiciona o respectivo objeto cliente, construído
                    // com os dados de retorno, à coleção de items.
                    fornecedores.Add(
                            new Fornecedor(
                         ulong.Parse(leitor["cnpj"].ToString()), leitor["nome"].ToString(), leitor["endereco"].ToString(),
                         leitor["email"].ToString(), leitor["tel"].ToString()
                         ));

                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return fornecedores;
        }

        public static void Excluir(Fornecedor fornecedor)
        {
            // Só é possível excluir uma tarefa cujo id
            // esteja especificado.
            if (fornecedor.Cnpj != 0)
            {
                MySqlCommand cmd;

                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                string sql = "DELETE FROM " + TABELA
                    + " WHERE cnpj = @cnpj;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@cnpj",
                    fornecedor.Cnpj);

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Fornecedor fornecedor, ulong cnpjAntigo)
        {
            MySqlCommand cmd;
            string sql;


            sql = "UPDATE " + TABELA
                + " SET cnpj = @cnpj, tel = @tel, email = @email, nome = @nome, endereco = @endereco"
                + " WHERE cnpj = @cnpjAntigo;";

            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql,
                BancoDados.RecuperarConexao());

            // Inserção de valores nos parâmetros.
            cmd.Parameters.AddWithValue("@cnpj",
                fornecedor.Cnpj);

            cmd.Parameters.AddWithValue("@endereco",
                fornecedor.Endereco);

            cmd.Parameters.AddWithValue("@nome",
                fornecedor.Nome);

            cmd.Parameters.AddWithValue("@email",
                fornecedor.Email);

            cmd.Parameters.AddWithValue("@tel",
                fornecedor.Tel);

            cmd.Parameters.AddWithValue("@cnpjAntigo",
                cnpjAntigo);
            


            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

    }
}
