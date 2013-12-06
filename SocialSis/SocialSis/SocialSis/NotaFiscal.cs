using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class NotaFiscal
    {
        private ulong nBoleto;
        private DateTime dataPagamento;
        private DateTime dataCompra;
        private DateTime dataVencimento;
        private double precoTotal;


        public ulong NBoleto
        {
            get { return nBoleto; }
            set { nBoleto = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        public double PrecoTotal
        {
            get { return precoTotal; }
            set { precoTotal = value; }
        }

    }
}
