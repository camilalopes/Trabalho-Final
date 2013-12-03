using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;

namespace Dao
{
    class CompraDao
    {
        public static readonly string TABELA = "item";


        public static void salvar(Compra compra)
        {
            MySqlCommand cmd;
            string sql;

            if (compra.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @dataCompra, @total, @dataPagamento, @fk_cliente);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataPagamento",
                    compra.DataPagamento);

                cmd.Parameters.AddWithValue("@dataCompra",
                    compra.DataCompra);

                cmd.Parameters.AddWithValue("@total",
                    compra.Total);

                cmd.Parameters.AddWithValue("@fk_cliente",
                    compra.Cliente.Cpf);

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET dataCompra = @dataCompra, total = @total, dataPagamento = @dataPagamento, fk_cliente = @fk_cliente"
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    compra.GetId());

                cmd.Parameters.AddWithValue("@dataPagamento",
                    compra.DataPagamento);

                cmd.Parameters.AddWithValue("@dataCompra",
                    compra.DataCompra);

                cmd.Parameters.AddWithValue("@total",
                    compra.Total);

                cmd.Parameters.AddWithValue("@fk_cliente",
                    compra.Cliente.Cpf);

            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

    }
}
