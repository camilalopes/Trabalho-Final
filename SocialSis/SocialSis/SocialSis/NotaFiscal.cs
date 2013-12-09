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
        private Fornecedor fornecedor;
        private int id;

        public NotaFiscal()
        { }

        public NotaFiscal(int id, ulong nBoleto, DateTime dataPagamento, DateTime dataCompra, DateTime dataVencimento,
            double precoTotal, Fornecedor fornecedor)
        {
            SetId(id);
            NBoleto = nBoleto;
            DataPagamento = dataPagamento;
            DataCompra = dataCompra;
            DataVencimento = dataVencimento;
            PrecoTotal = precoTotal;
            Fornecedor = fornecedor;
        }

        public ulong NBoleto
        {
            get { return nBoleto; }
            set { nBoleto = value; }
        }

        public Fornecedor Fornecedor
        {
            get{ return fornecedor; }
            set{ fornecedor = value;}
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

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

    }
}