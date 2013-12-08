using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SocialSis;


namespace Dao
{
    class UsuarioDao
    {
        public static readonly string TABELA = "usuario";

        public static void Salvar(Usuario usuario)
        {
            MySqlCommand cmd;
            string sql;


            if (usuario.Login != null)
            {
                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                sql = "INSERT INTO " + TABELA
                    + " VALUES (@login, @senha, @nome, @telefone, @email, @adm);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@login",
                    usuario.Login);
                cmd.Parameters.AddWithValue("@senha",
                    usuario.GetSenha());
                cmd.Parameters.AddWithValue("@nome",
                    usuario.Nome);
                cmd.Parameters.AddWithValue("@telefone",
                    usuario.Telefone);
                cmd.Parameters.AddWithValue("@email",
                    usuario.Email);
                cmd.Parameters.AddWithValue("@adm",
                    usuario.Adm);

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Usuario usuario, string lAntigo)
        {
            MySqlCommand cmd;
            string sql;


            sql = "UPDATE " + TABELA
                + " SET login = @login,senha = @senha, nome = @nome,"
                + "telefone = @telefone, email = @email, adm = @adm"
                + " WHERE login=@loginAntigo;";

            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql,
                BancoDados.RecuperarConexao());

            // Inserção de valores nos parâmetros.
            cmd.Parameters.AddWithValue("@login",
                usuario.Login);
            cmd.Parameters.AddWithValue("@senha",
                usuario.GetSenha());
            cmd.Parameters.AddWithValue("@nome",
                usuario.Nome);
            cmd.Parameters.AddWithValue("@telefone",
                usuario.Telefone);
            cmd.Parameters.AddWithValue("@email",
                usuario.Email);
            cmd.Parameters.AddWithValue("@adm",
                usuario.Adm);
            cmd.Parameters.AddWithValue("@loginAntigo",
                lAntigo);


            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

        public static ArrayList BuscarTodos(Usuario usuario)
        {
            // Reposta padrão.
            ArrayList usuarios = new ArrayList();

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
                usuarios.Add(
                    new Usuario(
                        leitor["login"].ToString(), leitor["senha"].ToString(),
                        leitor["nome"].ToString(), ulong.Parse(leitor["telefone"].ToString()), leitor["email"].ToString(), bool.Parse(leitor["adm"].ToString())
                    )
                );
            }

            // Libera recursos de memória.
            leitor.Close();
            return usuarios;
        }



        public static Usuario BuscarPorLoginESenha(Usuario usuario)
        {
            Usuario resposta = null;

            if (usuario.Login != "")
            {
                MySqlCommand cmd;
                string sql = "SELECT * FROM " + TABELA + " WHERE login = @login and senha = @senha;";


                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.GetSenha());

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();


                if (leitor.Read())
                {
                    // adiciona o respectivo objeto Destinatario, construído
                    // com os dados de retorno, à coleção de destinatarios.
                    resposta = (new Usuario(leitor["login"].ToString(), leitor["senha"].ToString(), bool.Parse(leitor["adm"].ToString())));

                }

                leitor.Close();

            }

            return resposta;

        }

        public static Usuario BuscarPorLogin(Usuario usuario)
        {
            Usuario resposta = null;

            if (usuario.Login != "")
            {
                MySqlCommand cmd;
                string sql = "SELECT * FROM " + TABELA + " WHERE login = @login;";


                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

                cmd.Parameters.AddWithValue("@login", usuario.Login);

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();


                if (leitor.Read())
                {
                    // adiciona o respectivo objeto Destinatario, construído
                    // com os dados de retorno, à coleção de destinatarios.
                    resposta = (new Usuario(leitor["login"].ToString(), leitor["senha"].ToString(), bool.Parse(leitor["adm"].ToString())));

                }

                leitor.Close();

            }

            return resposta;

        }
    }
}
