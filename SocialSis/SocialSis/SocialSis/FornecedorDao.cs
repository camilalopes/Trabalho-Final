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

            if (fornecedor.Cnpj != 0)
            {
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

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET tel = @tel, email = @email, nome = @nome, endereco = @endereco"
                    + " WHERE cnpj = @cnpj;";

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
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

        public static ArrayList buscarTodos(Fornecedor fornecedor)
        {
            // Reposta padrão.
            ArrayList fornecedores = null;

            // Cria uma coleção vazia.
            fornecedores = new ArrayList();

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
                         ulong.Parse(leitor["cnpj"].ToString()), leitor["nome"].ToString(), leitor["endereco"].ToString(),
                         leitor["email"].ToString(), leitor["tel"].ToString() 
                        ));


            }

            // Libera recursos de memória.
            leitor.Close();


            return fornecedores;
        }
    }
}
