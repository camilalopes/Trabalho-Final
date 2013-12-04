using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Produto
    {
        private int id;
        private string descricao;
        private double precoUnitario;

        public Produto() { }

        public Produto(int id, string descricao, double precoUnitario)
        {
            SetId(id);
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
        }

        public Produto(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public override string ToString()
        {
            return descricao;
        }


    }
}
