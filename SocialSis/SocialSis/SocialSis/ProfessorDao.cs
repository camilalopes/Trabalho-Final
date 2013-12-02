using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;

namespace Dao
{
    class ProfessorDao
    {
        public static readonly string TABELA = "professor";

        public static void salvarProfessor(Professor professor)
        {
            MySqlCommand cmd;
            string sql;
            string sql2;

            if (professor.Cpf == null)
            {
                sql = "insert into cliente values (@cpf, @rg, @nome, @email, @tel," +
                " @endereco);";

                sql2 = "insert into " + TABELA + " values (@fk_cliente, @contratado);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@cpf",
                    professor.Cpf);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@rg",
                    professor.Rg);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    professor.Nome);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@email",
                    professor.Email);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@tel",
                    professor.Tel);

                /* Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataNasc",
                    professor.DataNasc);*/

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@endereco",
                    professor.Endereco);


                /* Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@prevPagamento",
                    professor.PrevPagamento);*/

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@fk_cliente",
                    professor.Cpf);
                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@contratado",
                    professor.Contratado);



                /*else
                {

                    sql = "UPDATE " + TABELA
                        + " SET descricao = @descricao"
                        + " WHERE id=@id;";

                    // Associação do comando à conexão.
                    cmd = new MySqlCommand(sql,
                        BancoDados.recuperarConexao());

                    // Inserção de valores nos parâmetros.
                    cmd.Parameters.AddWithValue("@descricao",
                        item.Descricao);
                    cmd.Parameters.AddWithValue("@id",
                        item.GetId());
                }*/

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }

    }
}
