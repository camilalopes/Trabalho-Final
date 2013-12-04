using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using Dao;
using MySql.Data.MySqlClient;

namespace Dao
{
    class ItemProdutoDao
    {
        public static readonly string TABELA = "itemProduto";


        public static void salvar(ItemProduto item)
        {
            MySqlCommand cmd;
            string sql;

            if (item.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @quantidade, @fk_compra, @fk_produto);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@quantidade",
                    item.Quantidade);

                cmd.Parameters.AddWithValue("@fk_produto",
                    item.Produto.GetId());

                cmd.Parameters.AddWithValue("@fk_compra",
                    item.Compra.GetId());

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET quantidade = @quantidade, fk_compra = @fk_compra, fk_produto = @fk_produto"
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    item.GetId());

                cmd.Parameters.AddWithValue("@quantidade",
                    item.Quantidade);

                cmd.Parameters.AddWithValue("@fk_produto",
                    item.Produto.GetId());

                cmd.Parameters.AddWithValue("@fk_compra",
                    item.Compra.GetId());



            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

    }
}

