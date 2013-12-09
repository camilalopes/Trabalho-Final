using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialSis;
using MySql.Data.MySqlClient;

namespace Dao
{
    class NotaFiscalDao
    {
        public static readonly string TABELA = "NotaFiscal";


        public static void Salvar(NotaFiscal notaFiscal)
        {
            MySqlCommand cmd;
            string sql;
            if (notaFiscal.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @nBoleto, @precoTotal, @dataPagamento, @dataVencimento , @dataCompra"
                    + ", @fk_fornecedor);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataPagamento",
                    notaFiscal.DataPagamento);

                cmd.Parameters.AddWithValue("@dataCompra",
                    notaFiscal.DataCompra);

                cmd.Parameters.AddWithValue("@dataVencimento",
                    notaFiscal.DataVencimento);

                cmd.Parameters.AddWithValue("@precoTotal",
                    notaFiscal.PrecoTotal);

                cmd.Parameters.AddWithValue("@fk_fornecedor",
                    notaFiscal.Fornecedor.Cnpj);

                cmd.Parameters.AddWithValue("nBoleto",
                    notaFiscal.NBoleto);
            }
            else
            {
                sql = "UPDATE " + TABELA
                     + " SET dataPagamento = @dataPagamento"
                     + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.RecuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    notaFiscal.GetId());

                cmd.Parameters.AddWithValue("@dataPagamento",
                    notaFiscal.DataPagamento);
            }



            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }

        public static ArrayList BuscarTodos(NotaFiscal nf)
        {
            ArrayList notasfiscais = new ArrayList();

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
                notasfiscais.Add(
                    new NotaFiscalAux(int.Parse(leitor["id"].ToString()),
                        ulong.Parse(leitor["nBoleto"].ToString()),
                        DateTime.Parse(leitor["dataPagamento"].ToString()),
                        DateTime.Parse(leitor["dataCompra"].ToString()),
                        DateTime.Parse(leitor["dataVencimento"].ToString()),
                        double.Parse(leitor["precoTotal"].ToString()),
                        int.Parse(leitor["fk_fornecedor"].ToString())));
            }
            // Libera recursos de memória.
            leitor.Close();


            return notasfiscais;

        }

        public static ArrayList BuscarTodos(NotaFiscalAux nfAux)
        {
            ArrayList notasfiscais = new ArrayList();

            MySqlCommand cmd;

            string sql = "select nf.id as id, nf.nBoleto as boleto, nf.dataVencimento as vencimento, nf.dataCompra as dataCompra, nf.precototal as total, nf.dataPagamento as" +
            " dataPagamento, ii.quantidade as quantidade, i.descricao as descricao, f.nome as" +
            " nome from insumo i inner join iteminsumo ii on ii.fk_insumo = i.id inner join" +
            " notafiscal nf on nf.id = ii.fk_notafiscal inner join fornecedor f on f.cnpj = nf.fk_fornecedor;";


            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql, BancoDados.RecuperarConexao());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();


            while (leitor.Read())
            {
                notasfiscais.Add(
                    new NotaFiscalAux(int.Parse(leitor["id"].ToString()),
                        ulong.Parse(leitor["boleto"].ToString()),
                        leitor["nome"].ToString(),
                        leitor["descricao"].ToString(),
                        int.Parse(leitor["quantidade"].ToString()),
                        DateTime.Parse(leitor["dataPagamento"].ToString()),
                        DateTime.Parse(leitor["vencimento"].ToString()),
                       DateTime.Parse(leitor["dataCompra"].ToString()),
                       double.Parse(leitor["total"].ToString())));
            }

            // Libera recursos de memória.
            leitor.Close();


            return notasfiscais;

        }

        /*
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

         }*/

    }
}
