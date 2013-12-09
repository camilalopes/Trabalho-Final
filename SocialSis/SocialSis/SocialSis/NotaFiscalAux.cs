using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class NotaFiscalAux
    {
        private ulong nBoleto;
        private DateTime dataPagamento;
        private DateTime dataCompra;
        private DateTime dataVencimento;
        private double precoTotal;
        private string fornecedor;
        private string insumo;
        private int id;
        private int fk_fornecedor;
        private int quantidade;

        public NotaFiscalAux()
        { }

       public NotaFiscalAux(int id, ulong nBoleto, DateTime dataPagamento, DateTime dataCompra, DateTime dataVencimento,
            double precoTotal, int fk_fornecedor)
        {
            SetId(id);
            NBoleto = nBoleto;
            DataPagamento = dataPagamento;
            DataCompra = dataCompra;
            DataVencimento = dataVencimento;
            PrecoTotal = precoTotal;
            SetFkFornecedor(fk_fornecedor);

        }

       public NotaFiscalAux(int id, ulong nBoleto,string fornecedor,
           string insumo, int quantidade,DateTime dataPagamento, DateTime dataVencimento,
            DateTime dataCompra,
            double precoTotal)
       {
           SetId(id);
           NBoleto = nBoleto;
           DataPagamento = dataPagamento;
           DataCompra = dataCompra;
           PrecoTotal = precoTotal;
           Fornecedor = fornecedor;
           Insumo = insumo;
           Quantidade = quantidade;
           DataVencimento = dataVencimento;


       }

       public int Quantidade
       {
           get { return quantidade; }
           set { quantidade = value; }
       }


        public ulong NBoleto
        {
            get { return nBoleto; }
            set { nBoleto = value; }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public string Insumo
        {
            get { return insumo; }
            set { insumo = value; }
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

        public void SetFkFornecedor(int fk_fornecedor)
        {
            this.fk_fornecedor = fk_fornecedor;
        }

        public int GetFkFornecedor()
        {
            return this.fk_fornecedor;
        }
    }
}
