using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    /// <summary>
    /// Classe responsável por representar uma compra no sistema
    /// </summary>
    class Compra
    {
        private int id;
        //Atributo resposável por guardar o id da compra

        private DateTime dataPagamento;
        //Atributo responsavel por guardar a data de pagamento da compra

        private DateTime dataCompra;
        //Atributo responsável por guardar a data de compra 

        private double total;
        //Atributo responsavel por guardar o preço total da compra

        private Cliente cliente;
        //Atributo responsavel por guardar o cliente que fez a compra

        //Não falta guardar o produto tbm não????

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public Compra() { }

        /// <summary>
        /// Construtor sobrecarregado da classe, todos os atributos como parametro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataPagamento"></param>
        /// <param name="dataCompra"></param>
        /// <param name="total"></param>
        /// <param name="cliente"></param>
        public Compra(int id, DateTime dataPagamento, DateTime dataCompra, double total, Cliente cliente)
        {
            SetId(id);
            DataCompra = dataCompra;
            DataPagamento = dataPagamento;
            Total = total;
            Cliente = cliente;
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

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo da data da compra
        /// </summary>
        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo da data de pagamento da compra
        /// </summary>
        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do attributo preço total da compra
        /// </summary>
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        /// <summary>
        /// Propriedade responsável por guardar e retornar valores do atributo cliente da compra
        /// </summary>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        /// <summary>
        /// Metodo responsavel por calcular o valor total da compra, produto e quantidade como parametros
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        /// <returns></returns>
        public double calcularTotal(Produto produto, int quantidade)
        {
            double total;
            total = produto.PrecoUnitario * quantidade;
            return total;          
        }
    }
}
