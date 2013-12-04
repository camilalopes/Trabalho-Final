using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class ItemProduto
    {
        private int id;
        private int quantidade;
        private Compra compra;
        private Produto produto;

        public ItemProduto() { }

        public ItemProduto(int id, int quantidade, Compra compra, Produto produto)
        {
            SetId(id);
            Quantidade = quantidade;
            Compra = compra;
            Produto = produto;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade=value; }
        }

        public Compra Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }

    }
}
