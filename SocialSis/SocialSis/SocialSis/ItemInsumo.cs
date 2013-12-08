using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSis
{
    class ItemInsumo
    {
        private int id;
        private int quantidade;
        private NotaFiscal notaFiscal;
        private Insumo insumo;


        public ItemInsumo() { }

        public ItemInsumo(int id, int quantidade, NotaFiscal notaFiscal, Insumo insumo)
        {
            SetId(id);
            Quantidade = quantidade;
            NotaFiscal = notaFiscal;
            Insumo = insumo;

        }

        public Insumo Insumo
        {
            get { return insumo; }
            set { insumo = value; }
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
            set { quantidade = value; }
        }

        public NotaFiscal NotaFiscal
        {
            get { return notaFiscal; }
            set{notaFiscal = value;}
        }

    }
}
