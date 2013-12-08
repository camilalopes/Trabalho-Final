using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SocialSis;

namespace Dao
{
    class ItemInsumoDao
    {
        public static readonly string TABELA = "itemInsumo";


        public static void Salvar(ItemInsumo item)
        {
            MySqlCommand cmd;
            string sql;

            if (item.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @quantidade, @fk_insumo, @fk_notafiscal);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@quantidade",
                    item.Quantidade);

                cmd.Parameters.AddWithValue("@fk_insumo",
                    item.Insumo.GetId());

                cmd.Parameters.AddWithValue("@fk_notafiscal",
                    item.NotaFiscal.NBoleto);

            }
            else
            {

                sql = "UPDATE " + TABELA
                    + " SET quantidade = @quantidade, fk_insumo = @fk_insumo, fk_notafiscal = @fk_notafiscal"
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    item.GetId());

                cmd.Parameters.AddWithValue("@quantidade",
                    item.Quantidade);

                cmd.Parameters.AddWithValue("@fk_insumo",
                    item.Insumo.GetId());

                cmd.Parameters.AddWithValue("@fk_notafiscal",
                    item.NotaFiscal.NBoleto);



            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }
    }
}
