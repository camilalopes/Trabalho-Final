using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Insumo
    {
        private int id;
        private string descricao;
        private double precoUnitario;

        public Insumo(int id, string descricao, double precoUnitario)
        {
            SetId(id);
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
        }


        public Insumo()
        { }

        public Insumo(int id)
        {
            SetId(id);
        }

        public Insumo(string descricao)
        {
            Descricao = descricao;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public override string ToString()
        {
            return descricao;
        }
    }
}
