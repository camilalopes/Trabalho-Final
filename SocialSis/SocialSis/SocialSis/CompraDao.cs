using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;

namespace Dao
{
    /// <summary>
    /// Classe responsável por realizar as operações na tabela "compra" no Banco de Dados Local
    /// </summary>
    class CompraDao
    {
        public static readonly string TABELA = "compra";


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

        public static ArrayList buscarTodos(Compra compra)
        {
            ArrayList compras = new ArrayList();

            MySqlCommand cmd;
            string sql = "SELECT * FROM " + TABELA + ";";


            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();


            while (leitor.Read())
            {
                compras.Add(
                    new CompraAux(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataPagamento"].ToString()),
                        DateTime.Parse(leitor["dataCompra"].ToString()),
                        double.Parse(leitor["total"].ToString()),
                        int.Parse(leitor["fk_cliente"].ToString())));
            }
            // Libera recursos de memória.
            leitor.Close();


            return compras;

        }

        public static ArrayList buscarTodos(CompraAux cAux)
        {
            ArrayList compras = new ArrayList();

            MySqlCommand cmd;
            string sql = "select co.dataCompra as dataCompra, co.total as total, co.dataPagamento as" +
            " dataPagamento, ip.quantidade as quantidade, p.descricao as descricao, c.nome as" +
            " nome from produto p inner join itemproduto ip on ip.fk_produto = p.id inner join" +
            " compra co on co.id = ip.fk_compra inner join cliente c on c.cpf = co.fk_cliente;";


            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();


            while (leitor.Read())
            {
                compras.Add(
                    new CompraAux(DateTime.Parse(leitor["dataCompra"].ToString()),
                       leitor["nome"].ToString(), leitor["descricao"].ToString(), int.Parse(leitor["quantidade"].ToString()),
                       DateTime.Parse(leitor["dataPagamento"].ToString()), double.Parse(leitor["total"].ToString())));
            }
            // Libera recursos de memória.
            leitor.Close();


            return compras;

        }

        public static Compra BuscarPorId(Compra compra)
        {
            Compra resposta = null;
            MySqlCommand cmd;
            string sql = "SELECT * FROM " + TABELA + " WHERE id = @id";


            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

            cmd.Parameters.AddWithValue("@id", compra.GetId());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();


            if (leitor.Read())
            {
                    resposta = new Compra(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataPagamento"].ToString()),
                        DateTime.Parse(leitor["dataCompra"].ToString()),
                        double.Parse(leitor["total"].ToString()),
                        ClienteDao.buscarPorCpf(new Cliente(ulong.Parse(leitor["fk_cliente"].ToString()))));
            }
            // Libera recursos de memória.
            leitor.Close();


            return resposta;

        }

    }
}
