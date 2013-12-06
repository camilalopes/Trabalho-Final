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

        public CompraAux() { }

        public CompraAux(DateTime dataCompra, string cliente, string produto, int quantidade, DateTime dataPagamento, double total)
        {
            DataCompra = dataCompra;
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            DataPagamento = dataPagamento;
            Total = total;
            
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


    }
}
