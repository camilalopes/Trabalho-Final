using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Compra
    {
        private int id;
        private DateTime dataPagamento;
        private DateTime dataCompra;
        private double total;
        private Cliente cliente;

        public Compra() { }

        public Compra(int id, DateTime dataPagamento, DateTime dataCompra, double total)
        {
            SetId(id);
            DataCompra = dataCompra;
            DataPagamento = dataPagamento;
            Total = total;
        }


        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
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

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}
