using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Dao
{
    /// <summary>
    /// Classe responsável por realizar as operações com a tabela "cliente" no Banco de Dados local
    /// </summary>
    class ClienteDao
    {
        public static readonly string TABELA = "cliente";


        public static void salvar(Cliente cliente)
        {
            MySqlCommand cmd;
            string sql;

            if (cliente.Cpf != 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (@cpf, @rg, @nome, @email, @tel, @dataNasc, @endereco, @prevPagamento);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@cpf",
                    cliente.Cpf);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@rg",
                    cliente.Rg);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    cliente.Nome);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@email",
                    cliente.Email);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@tel",
                    cliente.Tel);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataNasc",
                    cliente.DataNasc);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@endereco",
                    cliente.Endereco);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@prevPagamento",
                    cliente.PrevPagamento);

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET rg = @rg, nome = @nome, email = @email, tel = @tel, dataNasc = @dataNasc, " +
                    "endereco = @endereco, prevPagamento = @prevPagamento"
                    + " WHERE cpf = @cpf;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@cpf",
                    cliente.Cpf);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@rg",
                    cliente.Rg);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    cliente.Nome);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@email",
                    cliente.Email);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@tel",
                    cliente.Tel);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataNasc",
                    cliente.DataNasc);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@endereco",
                    cliente.Endereco);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@prevPagamento",
                    cliente.PrevPagamento);
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

        public static ArrayList buscarTodos(Cliente cliente)
        {
            // Reposta padrão.
            ArrayList clientes = null;

            // Cria uma coleção vazia.
            clientes = new ArrayList();

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
                clientes.Add(
                    new Cliente(
                        leitor["nome"].ToString(), ulong.Parse(leitor["cpf"].ToString()), leitor["rg"].ToString(),
                         leitor["email"].ToString(), ulong.Parse(leitor["tel"].ToString()), leitor["endereco"].ToString(),
                        DateTime.Parse(leitor["prevPagamento"].ToString()), DateTime.Parse(leitor["dataNasc"].ToString())
                        ));


            }

            // Libera recursos de memória.
            leitor.Close();


            return clientes;
        }


        public static ArrayList buscarListaPorNome(Cliente cliente)
        {
            // Reposta padrão.
            ArrayList clientes = null;

            // Só é possível localizar uma item cuja descrição
            // esteja especificada.
            if (cliente.Nome != null)
            {
                // Cria uma coleção vazia.
                clientes = new ArrayList();

                MySqlCommand cmd;


                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome LIKE @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    "%" + cliente.Nome + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    // adiciona o respectivo objeto cliente, construído
                    // com os dados de retorno, à coleção de items.
                    clientes.Add(
                        new Cliente(
                            leitor["nome"].ToString(), ulong.Parse(leitor["cpf"].ToString()), leitor["rg"].ToString(),
                             leitor["email"].ToString(), ulong.Parse(leitor["tel"].ToString()), leitor["endereco"].ToString(),
                            DateTime.Parse(leitor["prevPagamento"].ToString()), DateTime.Parse(leitor["dataNasc"].ToString())
                            ));


                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return clientes;
        }

        public static Cliente buscarPorNome(Cliente cliente)
        {
            Cliente resposta = null;

            if (cliente.Nome != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome LIKE @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    "%" + cliente.Nome + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Cliente(
                            leitor["nome"].ToString(), ulong.Parse(leitor["cpf"].ToString()), leitor["rg"].ToString(),
                             leitor["email"].ToString(), ulong.Parse(leitor["tel"].ToString()), leitor["endereco"].ToString(),
                            DateTime.Parse(leitor["prevPagamento"].ToString()), DateTime.Parse(leitor["dataNasc"].ToString())
                            );


                }
                leitor.Close();
            }


            return resposta;

        }
    }
}
