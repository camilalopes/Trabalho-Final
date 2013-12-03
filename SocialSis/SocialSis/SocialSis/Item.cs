using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class Item
    {
        private int id;
        private int quantidade;

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

    }
}
