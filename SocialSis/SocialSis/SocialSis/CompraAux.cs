using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class CompraAux
    {
        /// <summary>
        /// Classe para auxiliar a representação de uma compra no sistema
        /// </summary>
        private DateTime dataPagamento;
        private DateTime dataCompra;
        private double total;
        private int quantidade;
        private string produto;
        private string cliente;
        private int fk_cliente;
        private int id;
        /*private string usuario;*/

        public CompraAux() { }

        public CompraAux(int id, DateTime dataPagamento, DateTime dataCompra, double total, int fK_cliente/* Usuario usuario*/)
        {
            SetId(id);
            DataCompra = dataCompra;
            DataPagamento = dataPagamento;
            Total = total;
            Cliente = cliente;
           // Usuario = usuario;
        }

        public CompraAux(DateTime dataCompra, string cliente, string produto, int quantidade, DateTime dataPagamento, double total/* string usuario*/)
        {
            DataCompra = dataCompra;
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            DataPagamento = dataPagamento;
            Total = total;
            Fk_cliente = fk_cliente;
            /* Usuario = usuario;*/
            
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Produto
        {
            get { return  produto; }
            set { produto = value; }
        }

        public int Fk_cliente
        {
            get { return fk_cliente; }
            set { fk_cliente = value; }
        }
        

        /// <summary>
        /// Metodo responsável por setar valor para o id da compra
        /// </summary>
        /// <param name="id"></param>
        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Metodo responsavel por retornar o valor do id da compra
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.id;
        }

        /* public string Usuario
         {
             get { return usuario; }
             set { usuario = value; }
         }*/


    }
}
